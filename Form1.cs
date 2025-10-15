using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一个窗体应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ToSingle
            int i1;
            i1 = Convert.ToInt32(textBox1.Text);
            int i2=Convert.ToInt32(textBox2.Text);
            int i3 = i1 + i2;
            textBox3.Text=Convert.ToString(i3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i1;
            i1 = Convert.ToInt32(textBox1.Text);
            int i2 = Convert.ToInt32(textBox2.Text);
            int i3 = i1 - i2;
            textBox3.Text = Convert.ToString(i3);
        }
    }
}
