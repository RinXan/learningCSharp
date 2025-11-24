using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            Shop<int> ids = new Shop<int>([1, 2, 3, 4, 5, 6]);
            Shop<string> items = new Shop<string>(["apple", "potato"]);

            ids.PrintObj();
            items.PrintObj();
        }
    }
}