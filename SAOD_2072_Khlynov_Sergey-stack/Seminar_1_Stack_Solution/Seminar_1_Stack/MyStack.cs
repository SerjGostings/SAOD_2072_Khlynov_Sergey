using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_1_Stack
{
    class MyStack <T>
    {
        private int current;
        private T[] array;

        public MyStack(int value)
        {
            array = new T[value];
            current = -1;
        }
        public void Push(T value)
        {
            if (current >= array.Length - 1)
            {
                throw new Exception();
            }
            else
            {
                current++;
                array[current] = value;
            }
        }
        public T Top()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                return array[current];
            }
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                T returner = array[current];
                array[current] = default(T);
                current--;
                return returner;
            }
        }
        public bool IsEmpty()
        {
            if (current < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T[] ToString()
        {
            return array;
        }
    }
}
