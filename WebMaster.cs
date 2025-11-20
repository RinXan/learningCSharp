using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WebMaster(string url, int id, string login, string password) : User(id, login, password)
    {
        public string Url { get; set; } = url;

        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tURL: {Url}";
        }
    }
}
