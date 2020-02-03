using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AutorizationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 для регстрации: ");
            Console.WriteLine("Введите 2 для входа: ");
            var input =  Console.ReadLine();
            if (input == "1")             //регистрация
            {
                Console.Write("Введите логин: ");
                var loginInput = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var passwordInput = Console.ReadLine();
                Console.Write("Введите пароль еще раз: ");
                var checkPasswordInput = Console.ReadLine();

                if (passwordInput.Equals(checkPasswordInput) == false)
                {
                    while (true)
                    {
                        Console.WriteLine("Введите пароль заново");
                        passwordInput = Console.ReadLine();
                        Console.Write("Введите пароль еще раз: ");
                        checkPasswordInput = Console.ReadLine();
                        if (passwordInput.Equals(checkPasswordInput))
                        {
                            break;
                        }
                    }


                }
                else
                {
                    checkPasswordInput = null;
                }
                Console.Write("Введите адресс электронной почты: ");
                var emailInput = Console.ReadLine();

                using (var context = new AutorizationContext())          //открытие БД
                {
                    var user = new User(loginInput, passwordInput, emailInput);
                    context.Users.Add(user);
                    context.SaveChanges();
                    Console.WriteLine("Готово!");
                    Console.Read();
                    
                }

            }
            else if (input == "2")
            {
                Console.Write("Введите логин: ");
                var loginInput = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var passwordInput = Console.ReadLine();

                using (var context = new AutorizationContext())
                {
                    
                    
                    var user = context.Users.FirstOrDefault(i => i.Login == loginInput && i.Password == passwordInput);
                    if (user != null)
                    {
                        Console.WriteLine("Успешно");
                    }
                    else
                    {
                        Console.WriteLine("Неверный логин или пароль");
                    }

                }
            }

            

        }
    }
}
