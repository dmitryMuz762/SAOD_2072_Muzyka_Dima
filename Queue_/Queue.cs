using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_
{
    class Queue<T>
    {
        private int _size; // - размер очереди
        private T[] arr; // - сама очередь
        private int currentIn; // - индекс элемента входа
        private int currentOut; // - индекс элемента выхода 
        private int count; // - общее число элементов в очереди 
        public Queue(int size)
        {
            arr = new T[size];
            currentIn = 0;
            currentOut = 0;
            count = 0;
            _size = size;
        }
        public void Push(T val) // - добавляет элемент в вверх
        {
            if (count > _size-2)
            {
                throw new Exception("Queue is full");
            }
            else
            {
                arr[currentIn++] = val;
                count++;
            }
            if (currentIn == _size)
            {
                currentIn = 0;
            }
        }
        public T Pop() // - возвращает верхий элемент и убирает его
        {
            if (currentOut == _size)
            {
                currentOut = 0;
            }
            if (IsEmpty() == false)
            {
                count--;
                T iout = arr[currentOut];
                arr[currentOut] = default;
                currentOut++;
                return iout;
            }
            else return arr[0];

        }
        public T Top() // - возвращает только нижний элемент
        {
            // если данных нет, выбрасываем исключение
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return arr[currentOut];
        }
        public T[] ToArray() // - возращает все элементы очереди
        {
            T[] _arr = new T[count];
            for (int i = 0; i < count; i++)
            {
                int flag = (currentOut + i) % arr.Length;
                _arr[i] = arr[flag];
            }

            return _arr;
        }
        public bool IsEmpty() // - проверяет пустой или нет
        {
            if (count == 0)
            {
                return true;
            }
            else return false;
        }
        public void Clean() // - очищает стек
        {
            arr = new T[_size];
            currentIn = 0;
            currentOut = 0;
            count = 0;
        }
    }
}
