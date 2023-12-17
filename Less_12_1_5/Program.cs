
using System.Collections.Generic;

namespace Less_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // объявляем переменные
            int valUsers;

            Console.WriteLine("ВЫ ЗАПУСТИЛИ ПРОГРАММУ ПО ТЕСТИРОВАНИЯ ЗАДАНИЯ 12.1.5!");
            Console.WriteLine();
            Console.WriteLine("Автор программы на совсем понял условия задачи - ");
            Console.WriteLine("поэтому не стреляйте пианиста - он играет как умеет!");
            Console.WriteLine();
            Console.WriteLine("Итак!");
            Console.Write("Введите кол-во пользователей, которые Вы хотите добавить в список: ");

            try
            {
                valUsers = Convert.ToInt32(Console.ReadLine());

                // создаем список из пользователей 
                List<User> listUser = new List<User>();
                    
                // переменные, которые считаем с консоли
                string log;
                string nameUser;
                string prem;
                bool premBool;

                // запускаем цикл с кол-вом итераций отобраннных пользователем
                for (int i = 0; i < valUsers; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ведите {0}-ого пользователя!", i+1);
                    Console.Write("Введите новый логин: ");
                    log = Console.ReadLine();
                    Console.Write("Введите имя пользователя: ");
                    nameUser = Console.ReadLine();
                    Console.WriteLine("Хотите ли Вы прем-аккаунт ?");
                    Console.Write("1 - да / 0 - нет: ");
                    prem = Console.ReadLine();
                    if (Convert.ToInt32(prem)==1)
                    {
                        premBool = true;
                    }
                    else
                    {
                        premBool = false;
                    }

                    // добавляем нового пользвателя
                    listUser.Add(new User(log, nameUser, premBool));
                }

                Console.WriteLine();
                Console.WriteLine("Добавление {0}-х пользователей закончено!", valUsers);
                Console.WriteLine("Начинаем приветствие и показ рекламы!");
                Console.WriteLine();

                foreach (var nUser in listUser)
                {
                    Console.WriteLine("{0}, привет!", nUser.Name);
                    if (nUser.IsPremium == false)
                    {
                        Console.WriteLine("Пожалуйста, посмотрите нашу рекламу!");
                        ShowAds();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("У Вас прем-аккаунт! Реклама не будет показана!");
                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Прроизошла непредвиденная ошибка! Автор программы спешит (и волосы назад) на помощь!");
                Console.WriteLine("Но программа все равно будет закрыта!");
            }
        }

        // в этом же классе разрабатываем статический метод с показом рекламы
        // хотя конечно этот метод надо было его вынести в отдельный класс - что бы "не мешался под ногами" 

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

    }
}