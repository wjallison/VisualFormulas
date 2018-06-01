using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using org.mariuszgromada.math.mxparser;

namespace VisualFormulas
{
    public partial class Form1 : Form
    {
        public bool addnew = false;
        public List<group> formList = new List<group>();
        public static group selected;
        public static bool selectedActive = false;

        public Form1()
        {
            InitializeComponent();

            
            //Expression e = new Expression("1");
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Button test = new Button();
            //test.Width = 150;
            //test.Height = 70;
            //this.Controls.Add(test);
            
            ////test.Location
        }

        private void button2_Click(object sender, EventArgs e)  //addnewbutton toggles add new
        {
            if (!addnew) { addnew = true; }
            else { addnew = false; }
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            //Button test = new Button();
            ////test.Width = 150;
            ////test.Height = 70;
            ////this.Controls.Add(test);
            //this.tabPage1.Controls.Add(test);

            //test.Location = e.Location;
            if (!addnew) { return; }

            group test = new group();
            test.grouper.Location = e.Location;
            this.tabPage1.Controls.Add(test.grouper);

            formList.Add(test);
        }

        
    }

    public class group
    {
        //Planned: button to close groupbox

        public GroupBox grouper;
        public TextBox titleBox, formulaBox, evaluateBox;
        public Label l1, l2;
        public PictureBox inputs;
        public PictureBox output;

        public string formula;
        public double eval;

        public IDictionary<string, group> refs = new Dictionary<string, group>();

        public Color colorOut;

        public bool initInputs = true;

        public void init()
        {
            //initialize all
            grouper = new GroupBox();
            titleBox = new TextBox();
            formulaBox = new TextBox();
            evaluateBox = new TextBox();
            l1 = new Label();
            l2 = new Label();
            inputs = new PictureBox();
            output = new PictureBox();

            grouper.Size = new Size(210, 210);


            //Add controls and place them
            grouper.Controls.Add(titleBox);
            titleBox.Location = new Point(50, 18);

            grouper.Controls.Add(l1);
            l1.Location = new Point(50, 50);
            l1.Text = "Formula:";

            grouper.Controls.Add(formulaBox);
            formulaBox.Location = new Point(50, 80);

            grouper.Controls.Add(l2);
            l2.Location = new Point(50, 120);
            l2.Text = "Evaluates to:";

            grouper.Controls.Add(evaluateBox);
            evaluateBox.Location = new Point(50, 150);
            evaluateBox.Text = "0";

            grouper.Controls.Add(inputs);
            inputs.Location = new Point(16, 66);
            inputs.Size = new Size(24, 60);

            grouper.Controls.Add(output);
            output.Location = new Point(157, 159);
            output.Size = new Size(12, 12);


            //Select random color to represent evaluated value
            Random rnd = new Random();
            colorOut = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            output.BackColor = colorOut;
        }

        public group()
        {
            init();
            //formulaBox.TextChanged += new System.EventHandler(this.formulaBox_TextChanged);
            formulaBox.Leave += new System.EventHandler(this.formulaBox_Leave);
            output.Click += new System.EventHandler(this.output_Click);
            //inputs.MouseClick += new System.EventHandler(this.inputs_MouseClick);
            inputs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputs_MouseClick);
            grouper.Click += new EventHandler(this.grouper_Click);


            //MessageBox.Show(subEval("1+(1)+(1+(1))"));
        }
        private void formulaBox_TextChanged(object sender, EventArgs e) //Don't use.  Activates on every char typed
        {
            MessageBox.Show("test");
        }
        private void formulaBox_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            formula = formulaBox.Text;
            //List<string> sep = formula.Split(new char[]{ '[', ']'}).ToList();

            //MessageBox.Show(Convert.ToDouble(formula).ToString());

            Evaluate();

            //Evaluate();
        }

        private void output_Click(object sender, EventArgs e)
        {
            Form1.selected = this;
            Form1.selectedActive = true;
        }

        private void inputs_MouseClick(object sender, MouseEventArgs e)
        {
            //e.
            if (Form1.selectedActive)
            {
                //System.Drawing.Graphics g = Graphics.FromImage(inputs.Image);
                ////MessageBox.Show((refs.Count() % 2 * 12).ToString() + ", " + (refs.Count() / 2 * 12).ToString());
                //g.FillRectangle(new SolidBrush(Form1.selected.colorOut), 
                //    new Rectangle(refs.Count()%2*12, refs.Count()/2*12, 12, 12));
                
            }
            //else if (formulaBox.ContainsFocus)
            else if(formulaBox.Focused)
            {
                //MessageBox.Show("test");
                int i = e.X / 12 + 2 * (e.Y / 12);
                //MessageBox.Show(i.ToString());
                formulaBox.Text += "[" + (i + 1).ToString() + "]";
                formulaBox.SelectionStart = formulaBox.Text.Length;
                formulaBox.SelectionLength = 0;
            }
        }
        private void inputs_MouseDown(object sender, EventArgs e)
        {
            
        }

        private void grouper_Click(object sender, EventArgs e)
        {
            if (Form1.selectedActive)
            {
                if (initInputs)
                {
                    //inputs.Image = Form1.selected.output.Image;
                    //inputs.BackColor = Form1.selected.output.BackColor;
                    //inputs.Image = new Image();
                    Bitmap bmp = new Bitmap(24, 60);
                    using(Graphics gr = Graphics.FromImage(bmp)) { gr.Clear(Color.FromKnownColor(KnownColor.Window)); }
                    inputs.Image = bmp;
                    System.Drawing.Graphics g = Graphics.FromImage(inputs.Image);
                    g.FillRectangle(new SolidBrush(Form1.selected.colorOut), new Rectangle(0, 0, 12, 12));
                    //inputs.Image = bmp;


                    refs.Add("1", Form1.selected);
                    initInputs = false;
                    Form1.selectedActive = false;
                }
                else
                {
                    Bitmap bmp = new Bitmap(24, 60);
                    using (Graphics gr = Graphics.FromImage(bmp)) { gr.Clear(Color.FromKnownColor(KnownColor.Window)); }
                    inputs.Image = bmp;

                    System.Drawing.Graphics g = Graphics.FromImage(inputs.Image);
                    //g.FillRectangle(new SolidBrush(Form1.selected.colorOut), 
                    //    new Rectangle(refs.Count() % 2 * 12, refs.Count() / 2 * 12, 12, 12));

                    for (int i = 0; i < refs.Count(); i++)
                    {
                        g.FillRectangle(new SolidBrush(refs[(i+1).ToString()].colorOut),
                            new Rectangle(i % 2 * 12, i / 2 * 12, 12, 12));
                    }

                    refs.Add((refs.Count()+1).ToString(), Form1.selected);
                    Form1.selectedActive = false;
                }
            }
        }

        public void Evaluate()
        {
            //Insert values in place of [i]


            //Actually evaluate the expression
            //Expression e = new Expression(formula);
            //eval = e.calculate();

            //evaluateBox.Text = eval.ToString();

            evaluateBox.Text = parenReduce(formula);
        }
        public string subEval(string f)
        {
            //Remove whitespace
            string s = f;
            System.Text.RegularExpressions.Regex.Replace(s, @"\s+", "");

            if (s.Contains('('))
            {
                if (s.IndexOf('(') == 0)
                {
                    s = subEval(
                        subEval(s.Substring(1, s.IndexOf(')') - 1)) +
                        s.Substring(s.IndexOf(')') + 1));
                }
                else
                {
                    MessageBox.Show(s);
                    MessageBox.Show("1: " + s.Substring(0, s.IndexOf('(')));
                    MessageBox.Show("2: " + s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(') + 1)));
                    //MessageBox.Show()


                    s = subEval(
                        s.Substring(0, s.IndexOf('(')) +
                        subEval(s.Substring(s.IndexOf('(') + 1, s.IndexOf(')') - (s.IndexOf('(')+1))) +
                        s.Substring(s.IndexOf(')') + 1)
                        );
                }
                //string s = f.Substring(0,f.IndexOf('(') + subEval(f.Substring())
            }




            return s;
        }

        public string parenReduce(string f)
        {
            string s = f, sPrime = "";
            int counter, counterMax=10;
            List<int> ls = new List<int>();
            //foreach (char c in s) { ls.Add(' '); }

            while(counterMax > 0)
            {
                ls.Clear();
                counter = 0;
                counterMax = 0;
                sPrime = "";
                int insertIndex = -1;

                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i]=='('/* || s[i] == ')'*/)
                    {
                        counter++;
                        counterMax++;
                        //ls.Add(-1);
                        ls.Add(counter);
                    }
                    else if(s[i] == ')')
                    {
                        ls.Add(counter);
                        counter--;
                        //ls.Add(-1);
                        //ls.Add(counter);
                    }
                    else { ls.Add(counter); }
                }

                for(int i = 0; i < s.Length; i++)
                {
                    if (ls[i] == counterMax)
                    {
                        if(s[i]!= '(' && s[i]!= ')')
                        {
                            sPrime += s[i];
                        }
                        s = s.Remove(i, 1);
                        s = s.Insert(i, " ");
                        if(insertIndex == -1) { insertIndex = i; }
                    }
                }
                sPrime = arithEval(sPrime);
                s = s.Insert(insertIndex, sPrime);
                s = RemoveSpaces(s);
            }

            s = RemoveSpaces(s);
            return s;
        }

        public string arithEval(string f)
        {
            string s = f;
            List<int> ls = new List<int>();
            List<string> quantsS = new List<string>();
            List<double> quantsD = new List<double>();
            List<double> q3 = new List<double>();
            List<double> q4 = new List<double>();
            int qCount = 0;

            quantsS.Add("");
            for (int i = 0; i < f.Length; i++)
            {
                if (Char.IsNumber(f[i]) || f[i] == '.') { ls.Add(0); quantsS[qCount] += f[i]; }
                else if (f[i] == '+') { ls.Add(1); quantsS.Add(""); qCount++; }
                else if (f[i] == '-') { ls.Add(2); quantsS.Add(""); qCount++; }
                else if (f[i] == '*') { ls.Add(3); quantsS.Add(""); qCount++; }
                else if (f[i] == '/') { ls.Add(4); quantsS.Add(""); qCount++; }
            }

            if(quantsS.Count() == 1) { return quantsS[0]; }

            foreach (string qS in quantsS) { quantsD.Add(Double.Parse(qS)); }

            double q1 = quantsD[0], q2 = quantsD[1];
            qCount = 1;
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] == '*')
                {
                    //q3.Add(q1 * q2);
                    q1 = q1 * q2;
                    //q1 = q3.Last();
                    qCount++;
                    if (qCount == quantsD.Count()) { q3.Add(q1); break; }
                    q2 = quantsD[qCount];
                }
                else if (f[i] == '/')
                {
                    //q3.Add(q1 / q2);
                    q1 = q1 / q2;
                    //q1 = q3.Last();
                    qCount++;
                    if (qCount == quantsD.Count()) { q3.Add(q1); break; }
                    q2 = quantsD[qCount];
                }
                else if(f[i] == '+' || f[i] == '-')
                {
                    q3.Add(q1);
                    q1 = quantsD[qCount];
                    qCount++;
                    if(qCount == quantsD.Count()) { q3.Add(q2); break; }
                    q2 = quantsD[qCount];
                }
            }

            if (q3.Count() == 1) { return q3[0].ToString(); }

            q1 = q3[0]; q2 = q3[1];
            qCount = 1;
            for(int i = 0; i < f.Length; i++)
            {
                if(f[i]== '+')
                {
                    //q4.Add(q1 + q2);
                    //q1 = q4.Last();
                    q1 = q1 + q2;
                    qCount++;
                    if(qCount == q3.Count()) { break; }
                    q2 = q3[qCount];
                }
                else if (f[i] == '-')
                {
                    //q4.Add(q1 - q2);
                    //q1 = q4.Last();
                    q1 = q1 - q2;
                    qCount++;
                    if (qCount == q3.Count()) { break; }
                    q2 = q3[qCount];
                }
            }



            return q1.ToString();
        }

        public string RemoveSpaces(string f)
        {
            string s = "";
            for (int i = 0; i < f.Length; i++)
            {
                if(f[i]!=' ') { s += f[i]; }
            }
            return s;
        }
    }
}
