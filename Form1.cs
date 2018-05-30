using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public float eval;

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

            grouper.Controls.Add(inputs);
            inputs.Location = new Point(16, 66);
            inputs.Size = new Size(24, 60);

            grouper.Controls.Add(output);
            output.Location = new Point(157, 159);
            output.Size = new Size(12, 12);

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



        }
        private void formulaBox_TextChanged(object sender, EventArgs e) //Don't use.  Activates on every char typed
        {
            MessageBox.Show("test");
        }
        private void formulaBox_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            formula = formulaBox.Text;
            List<string> sep = formula.Split(new char[]{ '[', ']'}).ToList();
        }

        private void output_Click(object sender, EventArgs e)
        {
            Form1.selected = this;
            Form1.selectedActive = true;
        }

        private void inputs_MouseClick(object sender, EventArgs e)
        {
            if (Form1.selectedActive)
            {

            }
            else if (formulaBox.ContainsFocus)
            {
                MessageBox.Show("test");
            }
        }

        private void grouper_Click(object sender, EventArgs e)
        {
            if (Form1.selectedActive)
            {
                if (initInputs)
                {
                    inputs.Image = Form1.selected.output.Image;
                }
            }
        }
    }
}
