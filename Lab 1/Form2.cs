using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form2 : Form
    {
        bool[,] res;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = new bool[3,3];
            res[0,0] = Convert.ToInt32(textBox1.Text) != 0 ? true : false;
            res[1, 0] = Convert.ToInt32(textBox2.Text) != 0 ? true : false;
            res[2, 0] = Convert.ToInt32(textBox3.Text) != 0 ? true : false;
            res[0, 1] = Convert.ToInt32(textBox4.Text) != 0 ? true : false;
            res[1, 1] = Convert.ToInt32(textBox5.Text) != 0 ? true : false;
            res[2, 1] = Convert.ToInt32(textBox6.Text) != 0 ? true : false;
            res[0, 2] = Convert.ToInt32(textBox7.Text) != 0 ? true : false;
            res[1, 2] = Convert.ToInt32(textBox8.Text) != 0 ? true : false;
            res[2, 2] = Convert.ToInt32(textBox9.Text) != 0 ? true : false;

            this.Close();
        }

        public bool [,] GetRes()
        {
            return res;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
