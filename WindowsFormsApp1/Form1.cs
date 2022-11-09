using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxResize_Width.Text);
            int y = Convert.ToInt32(textBoxResize_Height.Text);
            this.Size = new Size(x, y);
            //this.Size = new Size(300, 500);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double opa = Convert.ToDouble(textBoxOpacity.Text);
            this.Opacity = opa;
            //this.Opacity = 1;
        }
    }
}
