using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct UserStruct
    {
        private int _id;
        private string _login;
        private string _password;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Login
        {
            get
            {
                return _login;
            }
            set
            { 
                _login = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public void Info()
        {
            Console.WriteLine($"ID: {Id}; LOGIN: {Login}; PASSWORD: {Password}");
        }
    }
    abstract class User(int id, string login, string password) : ILog
    {
        private int _id = id;
        private string _login = login;
        private string _password = password;

        public int Id { get { return _id; } set { _id = value; } }
        public string Login 
        { 
            get { return _login; } 
            set 
            {
                AddToLog($"Изменен логин у пользователя с ID: {Id}");
                _login = value; 
            } 
        }
        public string Password 
        { 
            get { return _password; } 
            set 
            {
                AddToLog($"Изменен пароль у пользователя с ID: {Id}");
                _password = value; 
            } 
        }
        public User() : this(0, "default", "qwerty")
        {
            Console.WriteLine("Default user created");
        }

        public virtual string PrintToConsole()
        {
            return $"ID: {Id}\tLOGIN: {Login}\tPASSWORD: {Password}";
        }
        public static bool operator >(User a, User b)
        {
            return a.Id > b.Id;
        }
        public static bool operator <(User a, User b) 
        {
            return a.Id < b.Id;
        }
        public abstract void PrintUser();

        public void AddToLog(string message)
        {
            Console.WriteLine($"[Добавляем в ЛОГ] {message}");
        }
    }
}
