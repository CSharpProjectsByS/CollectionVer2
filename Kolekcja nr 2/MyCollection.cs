using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcja_nr_2
{
    class MyCollection<T> : IList<T>
    {
            public T[] temps;

            public MyCollection(int size)
            {
                temps = new T[size];
            }

            public T this[int index]
            {
                get
                {
                    return temps[index];
                }
                set
                {
                    temps[index] = value;
                    Array.Sort(temps);
                    Console.WriteLine("Posortowane");
                }
            }

            public T this[char index]
            {
                get
                {
                    return temps[ConvertAlphabetToPosition(index)];
                }
                set
                {
                    temps[ConvertAlphabetToPosition(index)] = value;
                    Array.Sort(temps);
                }
            }

       /*
        T IList<T>.this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }*/

        public int Count
        {
            get
            {
                return temps.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        
        public void Add(T item)
        {
            Array.Resize(ref temps, temps.Length + 1);
            temps[temps.Length - 1] = item;
            Array.Sort(temps);
        }

        public void Clear()
        {
            Array.Resize(ref temps, 0);
        }

        public bool Contains(T item)
        {
            bool isContain = false;

            if (IndexOf(item) > -1)
            {
                isContain = true;
            }

            return isContain;
        }

        public int ConvertAlphabetToPosition(char letter)
            {
                letter = Char.ToUpper(letter);

                int index = ((int)(letter)) - 65;
                return index;
            }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex < temps.Length && array.Length > temps.Length - arrayIndex)
            {
                for (int i = 0, j = arrayIndex; i < array.Length; i++, j++)
                {
                    array[i] = temps[j];
                }
            }  
          
        }

        public int getCollectionSize()
            {
                return temps.Length;
            }

        

        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < temps.Length; i++)
            {
                if (Comparer<T>.Default.Compare(temps[i], item) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Insert(int index, T item)
        {
            temps[index] = item;
            Array.Sort(temps);
        }

        public bool Remove(T item)
        {
            int lengthBefore = temps.Length;

            temps = temps.Where(val => Comparer<T>.Default.Compare(val, item) != 0).ToArray();

            int lenghtAfter = temps.Length;

            if (lenghtAfter != lengthBefore)
            {
                return true;
            }
            else
            {
                return false;
            }
     
        }

        public void RemoveAt(int index)
        {
            if (index < temps.Length )
            {
                for (int i = index; i <= temps.Length - 2; i++)
                {
                    temps[i] = temps[i + 1];
                }

                Array.Resize(ref temps, temps.Length - 1);
            }
        }

        public void setCollectionSize(int size)
            {
                Array.Resize(ref temps, size);
            }

        public IEnumerator<T> GetEnumerator()
        {
            //Console.WriteLine("GetEnumerator");
            return (IEnumerator<T>) new MyEnumerator<T>(temps);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine("Zwrócono enumerator");
            return new MyEnumerator<T>(temps);
        }
    }
}
