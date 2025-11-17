using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WebMaster : User
    {
        public string Url { get; set; }

        public WebMaster(string url, int id, string login, string password) : base(id, login, password)
        {
            Url = url;
        }

        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tURL: {Url}";
        }
    }
}
