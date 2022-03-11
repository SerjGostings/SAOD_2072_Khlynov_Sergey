using System;

namespace task_Queue
{
    class Queue<T>
    {
        public int currentIn;
        public int currentOut;
        public int count;
        private T[] array;

        public Queue(int value)
        {
            array = new T[value];
            currentIn = -1;
            currentOut = -1;
            count = 0;
        }
        public void Push(T value)
        {
            if (currentIn >= array.Length-1) 
            {
                currentIn = -1;
            }
            if (count >= array.Length)
            {
                throw new Exception();
            }
            else
                currentIn++;
                array[currentIn] = value;
                count++;
        }
        public T Top()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            else
            {
                return array[currentIn];
            }
        }
        public T Pop()
        {
            if (currentOut >= array.Length-1) 
            {
                currentOut = -1;
            }
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
                currentOut++;
                T returner = array[currentOut];
                array[currentOut] = default(T);
                count--;
                return returner;
        }
        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T [] ToString() 
        {
            return array;
        }
    }
}
