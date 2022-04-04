using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    class Stack<T>
    {
        int size = 0;
        private T[] array;
        int n = 20;

        public Stack()
        {
            array = new T[n];
        }

        public Stack(int n)
        {
            this.n = n;
            array = new T[n];
        }
        public bool Push(T value)
        {
            if (!IsFull())
            {
                array[size] = value;
                size++;
                return true;
            }
            return false;

        }
        public T Pop()
        {
            size--;
            return array[size];
        }

        public T Top()
        {
            return array[size - 1];
        }

        public bool IsFull()
        {
            if (size >= n)
                return true;

            return false;
        }
        public bool IsEmpty()
        {
            if (size == 0)
                return true;
            return false;
        }

        public int Len()
        {
            return size;
        }

        public void Clear(int n)
        {
            this.n = n;
            array = new T[n];
        }
    }
}
