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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int width = int.Parse(TxtWidth.Text);
            int height = int.Parse(TxtHeight.Text);
            int area = height * width;
            LblAnswer.Text ="the area of a rectangle is: " + area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
