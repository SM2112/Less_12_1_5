using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_12_1_5
{
    // класс с описание пользователя
    internal class User
    {
        
        // вводим поля класса
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        // конструктор 
        public User(string log, string nameUser, bool prem)
        {
            Login = log;
            Name  = nameUser;
            IsPremium = prem;
        }
    }
}
