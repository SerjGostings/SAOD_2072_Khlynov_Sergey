using System;
using System.Windows.Forms;

namespace task_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int> queue = new Queue<int>(5);

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Push(int.Parse(textBox1.Text));
                ToList();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Insert number");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Queue Overflow");
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

        private void buttonTop_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(queue.Top().ToString());
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Queue is Empty");
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(queue.Pop().ToString());
                ToList();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Queue is Empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.currentIn.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.currentOut.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.count.ToString());
        }
    }
}