using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserSocial(int age, string name, int id, string login, string password) : User(id, login, password) 
    {
        private int _balance;
        public int Age { get; set; } = age;
        public int Balance 
        {
            get { return _balance; } 
            set 
            {
                AddToLog($"Изменен баланс у пользователя с ID: {Id}");
                _balance = value;
            } 
        }
        public string Name { get; set; } = name;

        public override string PrintToConsole()
        {
            return base.PrintToConsole() + $"\tNAME: {Name} AGE: {Age} BALANCE: {Balance}";
        }

        public override void PrintUser()
        {
            Console.WriteLine(base.PrintToConsole() + $"\tNAME: {Name} AGE: {Age} BALANCE: {Balance}");
        }

        public static UserSocial operator +(UserSocial l, UserSocial r)
        {
            return new UserSocial(l.Age + r.Age, l.Name + r.Name, l.Id + r.Id, l.Login + r.Login, l.Password + r.Password);
        }

        public override string ToString()
        {
            return $"UserSocial object: {Age}, {Name}, {Balance}, {Id}, {Login}, {Password}";
        }
    }
}
