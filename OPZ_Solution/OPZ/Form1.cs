using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPZ
{
    public partial class Form1 : Form
    {
        MyOPZ OPZ = new MyOPZ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPZ_label.Visible = true;
            OPZ_label.Text = "";
            string first_string = equationBox.Text;
            OPZ_label.Text = OPZ.ToOPZ(first_string);
            res_button.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            res_label.Visible = true;
            res_label.Text = "";
            string str_res = OPZ_label.Text;
            res_label.Text = Convert.ToString(OPZ.ToCalc(str_res));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OPZ_label.Visible = false;
            res_label.Visible = false;
            res_button.Enabled = false;
            OPZ_button.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OPZ_button.Enabled = true;
        }
    }
}

