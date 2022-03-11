using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar2_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyQueue<int> queue = new MyQueue<int>(5);

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Push(int.Parse(textBox1.Text));
                ToList();
            }
            catch (FormatException ex)
            {
                textBox2.Text = ("Insert number");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Queue Overflow");
            }
        }
        private void ToList()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < queue.ToString().Length; i++)
            {
                if (queue.ToString()[i] != default)
                {
                    listBox1.Items.Add(queue.ToString()[i]);
                }
            }
        }

        private void buttonPeek_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (queue.Peek().ToString());
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Queue is Empty");
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (queue.Pop().ToString());
                ToList();
            }
            catch (Exception ex)
            {
                textBox2.Text = ("Queue is Empty");
            }
        }

    }
}
