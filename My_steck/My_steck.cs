using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_steck
{

    class Stack<T>
    {
        private int current;
        private T[] array;
        int count = 0;
        public Stack(int shape)
        {
            array = new T[shape];
        }
        public void Push(T value)
        {
            if (current > array.Length - 1)
            {
                throw new Exception("Стек переполнен");
            }
            array[current] = value; current++; count++;
        }
        public T Top()
        {
            if (IsEmpty())
            {
                throw new Exception("Ошибка: Стэк пуст, добавьте элементы в стэк");
            }
            return array[current - 1];
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Ошибка: Стэк пуст, добавьте элементы в стэк");
            }
            current--;
            T returner = array[current];
            array[current] = default;
            count--; return returner;
        }
        public bool IsEmpty()
        {
            return current <= 0;
        }
        public T[] ToArray()
        {
            T[] arrayOut = new T[count];
            int index = count - 1;
            for (int i = current - 1; i > -1; i--)
            {
                arrayOut[index] = array[i];
                index--; 
            }

                return arrayOut; 
        }
    }
}
