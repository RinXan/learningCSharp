using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserSocial : User
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public UserSocial(int age, string name, int id, string login, string password) : base(id, login, password)
        {
            Age = age;
            Name = name;
        }

        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tNAME: {Name}\tAGE: {Age}";
        }
    }
}
