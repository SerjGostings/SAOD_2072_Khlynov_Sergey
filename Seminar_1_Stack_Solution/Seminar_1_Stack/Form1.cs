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
        class My_Stack 
        {
            int[] arr;
            int current, max_size;

            public My_Stack (int size)
            {
                arr = new int[size];
                max_size = size;
                current = 0;
            }

            public void push (int val) // добавление в стек
            {
                current++;
            }
            public int pop () // извлекает верхний элемент
            {
                int elem_to_pop = this.top();
                Array.Clear(arr, current, 1);
                current--;
                return elem_to_pop;
            }
            public int top () // показывает верхний элемент
            {
                int top_el = arr[current];
                return top_el;
            }
            public int[] ToArray () // возвращает весь стек (текущее содержимое)
            {
                int[] current_stack = arr;
                return current_stack;
            }
            public bool IsEmpty() // возвращает да/нет заполнен ли стек
            {
                bool emp;
                if (current == 0)
                {
                    emp = true;
                }
                else
                {
                    emp = false;
                }
                return emp;
            }
        }

    }
}
