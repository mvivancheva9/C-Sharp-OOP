using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T> where T : IComparable
    {
        private T[] list;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }
        private const int INITIAL_CAPACITY = 3;

        public GenericList(int capacity = INITIAL_CAPACITY)
        {
            this.list = new T[capacity];
            this.count = 0;
        }
        public T Max()
        {
            T max = list[0];

            for (int i = 1; i < this.list.Length; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public T Min()
        {
            T min = default(T);

            if (this.Count > 0)
            {
                min = this.list[0];

                for (int i = 1; i < this.Count; i++)
                {
                    if (min.CompareTo(this.list[i]) > 0)
                    {
                        min = this.list[i];
                    }
                }
            }
            return min;
        }
        public void Add(T item) 
        { 
            DoubleIfFull(); 
            this.list[this.count] = item; 
            this.count++;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.list.Length; i++) 
            { 
                if (object.Equals(item, this.list[i])) 
                {
                    return i; 
                } 
            }
            return -1;
        }
        public int Find(T element)
        {
            return Array.IndexOf(this.list, element);
        }
        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0) 
            { 
                throw new ArgumentOutOfRangeException("No Such Index");
            }
            T item = this.list[index]; 
            Array.Copy(this.list, index + 1, this.list, index, this.count - index - 1); 
            this.list[this.count - 1] = default(T); 
            this.count--;
            return item;
        }
        public void Insert(int index, T item) 
        {  
            if (index > this.count || index < 0)  
            {
                throw new IndexOutOfRangeException("No Such Index");
            } 
            DoubleIfFull(); 
            Array.Copy(this.list, index, this.list, index + 1, this.count - index); 
            this.list[index] = item; 
            this.count++;
        }
        private void DoubleIfFull() 
        { 
            if (this.count + 1 > this.list.Length) 
            { 
                T[] extendedArr = new T[this.list.Length * 2]; 
                Array.Copy(this.list, extendedArr, this.count); 
                this.list = extendedArr; 
            } 
        }
        public void Clear() 
        { 
            this.list = new T[INITIAL_CAPACITY]; 
            this.count = 0; 
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(list[i]);
                if (i < count - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }
    }
}
