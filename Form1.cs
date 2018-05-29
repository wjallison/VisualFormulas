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
        }

        
    }

    public class group
    {
        public GroupBox grouper;
        public TextBox titleBox, formulaBox, evaluateBox;
        public Label l1, l2;
        public PictureBox inputs;
        public PictureBox output;

        public void init()
        {
            grouper = new GroupBox();
            titleBox = new TextBox();
            formulaBox = new TextBox();
            evaluateBox = new TextBox();
            l1 = new Label();
            l2 = new Label();
            inputs = new PictureBox();
            output = new PictureBox();

            grouper.Size = new Size(210, 210);

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

            grouper.Controls.Add(output);
            output.Location = new Point(157, 159);
        }

        public group()
        {
            init();



            
        }
    }
}
