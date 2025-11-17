using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            UserSocial us = new UserSocial(22, "anna", 3902, "anna22", "qwerty22");
            WebMaster wm = new WebMaster("https://webmaster.com", 329921, "webm", "dostum32");

            us.Name = "Anna Makarova";
            wm.Url = "WEB Master";

            Console.WriteLine(us.PrintToConsole());
            Console.WriteLine(wm.PrintToConsole());
        }
    }
}