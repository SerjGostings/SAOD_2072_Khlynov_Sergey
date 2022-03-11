using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_1_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyStack<int> stack = new MyStack<int>(5);

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(int.Parse(textBox1.Text));
                ToList();
            }
            catch (FormatException ex)
            {
                textBox2.Text = ("Insert number");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Stack Overflow");
            }


        }
        private void ToList()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < stack.ToString().Length; i++)
            {
                if ((stack.ToString()[i] != default))
                {
                    listBox1.Items.Add(stack.ToString()[i]);
                }

            }
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (stack.Top().ToString());
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Stack is Empty");
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (stack.Pop().ToString());
                ToList();
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Stack is Empty");
            }
        }

    }
}
