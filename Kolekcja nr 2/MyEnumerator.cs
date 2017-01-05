using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcja_nr_2
{
    class MyEnumerator<T> : IEnumerator<T>
    {

        public T[] temps;
        int position = -1;

        public MyEnumerator(T[] list)
        {
            Console.WriteLine("Przypisano list do temps");
            temps = list;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }    
        }

        public T Current
        {
            get
            {
                try
                {
                    return temps[position];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Problem z exception");
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            Console.WriteLine("Przejście do kolejnego: " + position);
            position++;

            return (position < temps.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            
        }
    }
}
