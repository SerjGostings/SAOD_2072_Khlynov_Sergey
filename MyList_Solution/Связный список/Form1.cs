using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Связный_список
{
    public partial class Form1 : Form
    {
        MyList List = new MyList();
        MyData data;
        public Form1()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MyData data = new MyData();
            data.numb = Convert.ToInt32(textBox6.Text);
            data.name = textBox2.Text;
            if (radioButton1.Checked)
            {
                data.trueorfalse = true;
            }
            else
            {
                data.trueorfalse = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            data = new MyData();
            data.numb = Convert.ToInt32(textBox6.Text);
            data.name = textBox2.Text;  
            if (radioButton1.Checked)
            {
                data.trueorfalse = true;
            }
            else
            {
                data.trueorfalse = false;
            }

            List.AddToBegin(data);
            radioButton1.Checked = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new MyData();
            data.numb = Convert.ToInt32(textBox6.Text);
            data.name = textBox2.Text;
            if (radioButton1.Checked)
            {
                data.trueorfalse = true;
            }
            else
            {
                data.trueorfalse = false;
            }
            List.AddToEnd(data);
            radioButton1.Checked = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data = new MyData();
            data.numb = Convert.ToInt32(textBox6.Text);
            data.name = textBox2.Text;
            if (radioButton1.Checked)
            {
                data.trueorfalse = true;
            }
            else
            {
                data.trueorfalse = false;
            }
            List.AddToOrderList(data);
            radioButton1.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            MyData obj = List.Search(Convert.ToInt32(textBox4.Text));
            if (obj == null)
            {
                MessageBox.Show("не найдено");
            }
            textBox5.Text = $"Номер задания: {obj.numb}, Название : {obj.name}, Сдано ли?: {obj.trueorfalse}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List.Visual(listBox1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            List.Delete(Convert.ToInt32(textBox4.Text));
           
        }

      
    }
}
