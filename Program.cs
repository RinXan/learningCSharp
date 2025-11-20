using System;  

namespace ConsoleApp1
{
    class Program      
    {
        static void Main(string[] args)
        {
            UserSocial a1 = new(21, "Olga", 43, "olga43", "qwerty");
            WebMaster wm = new WebMaster("not known", 1, "undefined", "hhh");

            a1.PrintUser();
            
            a1.Login = "olga_54";
            a1.Password = "helasfjwe_fkek32!";
            a1.Balance = 30000;
            
            a1.PrintUser();

            wm.Url = "https://hltv.org";
            wm.PrintUser();
        }
    }
}