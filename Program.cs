using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            UserSocial a1 = new(21, 200, "Olga", 43, "olga43", "qwerty");
            WebMaster b1 = new("www.youtube.com", 43, "olga43", "qwerty");

            a1.PrintUser();
            b1.PrintUser();
        }
    }
}