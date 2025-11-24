using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop<T>
    {
        public T[] items = [];

        public Shop(T[] data) 
        {
            this.items = data;
        }

        public void PrintObj()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
