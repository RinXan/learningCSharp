using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            UserSocial us = new(22, "Olga", 20, "olga22", "qwerty");
            WebMaster wm = new("alskdjflas", 20, "predator", "wer");
            UserSocial us2 = new(221, "Olga213", 10, "123olga22", "q213werty");

            Console.WriteLine(wm);
            Console.WriteLine(us);
            Console.WriteLine(us2);

            Console.WriteLine(us.Equals(wm));
        }
    }
}