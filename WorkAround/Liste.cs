using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
    
    internal class Liste<T>
    {
        T[] values = [];
        // for ile yazmaya çalış

        public void Add(T item)
        {
            T[] tempArray = new T[values.Length + 1];
            Array.Copy(values, tempArray, values.Length);
            tempArray[tempArray.Length - 1] = item;
            values = tempArray;
        }
        public T[] GetAll()
        {
            return values;
        }

       
    }
}
