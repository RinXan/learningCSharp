using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            //User a = new(32, "Igor", "igor123");
            //User b = new(320, "Anna", "Anna321");

            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);

            UserSocial a1 = new(21, 200, "Olga", 43, "olga43", "qwerty");
            UserSocial a2 = new(19, 390, "Inna", 22, "Inna", "qwerty123");
            UserSocial a3 = a1 + a2;

            Console.WriteLine(a1.PrintToConsole());
            Console.WriteLine(a2.PrintToConsole());
            Console.WriteLine(a3.PrintToConsole());
        }
    }
}