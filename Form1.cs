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
        }

        
    }

    public class group
    {
        public GroupBox grouper;
        public TextBox titleBox, formulaBox, evaluateBox;
        public Label l1, l2;
        public PictureBox inputs;
        public PictureBox output;

        public group()
        {

        }
    }
}
