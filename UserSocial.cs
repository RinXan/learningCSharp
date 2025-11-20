using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserSocial(int age, int balance, string name, int id, string login, string password) : User(id, login, password)
    {
        public int Age { get; set; } = age;
        public int Balance { get; set; } = balance;
        public string Name { get; set; } = name;

        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tNAME: {Name}\tAGE: {Age}\tBALANCE: {Balance}";
        }

        public static UserSocial operator +(UserSocial l, UserSocial r)
        {
            return new UserSocial(l.Age + r.Age, l.Balance + r.Balance, l.Name + r.Name, l.Id + r.Id, l.Login + r.Login, l.Password + r.Password);
        }
    }
}
