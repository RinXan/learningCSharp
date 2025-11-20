using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WebMaster(string url, int id, string login, string password) : User(id, login, password)
    {
        private string _url = url;
        public string Url
        {
            get { return _url; }
            set
            {
                AddToLog($"Изменена ссылка у пользователя с ID: {Id}");
                _url = value;
            }
        }


        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tURL: {Url}";
        }

        public override void PrintUser()
        {
            Console.WriteLine(base.PrintToConsole() + $"\tURL: {Url}");
        }
    }
}
