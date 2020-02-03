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
            Console.Write("Enter 1 to sign up: ");
            Console.WriteLine("Enter 2 to sign in: ");
            var input =  Console.ReadLine();
            if (input == "1")             //register
            {
                Console.Write("Enter login: ");
                var loginInput = Console.ReadLine();
                Console.Write("Enter password: ");
                var passwordInput = Console.ReadLine();
                Console.Write("Enter the password again: ");
                var checkPasswordInput = Console.ReadLine();

                if (passwordInput.Equals(checkPasswordInput) == false)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the password again: ");
                        passwordInput = Console.ReadLine();
                        Console.Write("Enter the password again: ");
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
                Console.Write("Enter the Email: ");
                var emailInput = Console.ReadLine();

                using (var context = new AutorizationContext())          
                {
                    var user = new User(loginInput, passwordInput, emailInput);
                    context.Users.Add(user);
                    context.SaveChanges();
                    Console.WriteLine("Success!");
                    Console.Read();
                    
                }

            }
            else if (input == "2")                  //sign in
            {
                

                using (var context = new AutorizationContext())
                {
                    while (true)
                    {
                        Console.Write("Enter login: ");
                        var loginInput = Console.ReadLine();
                        Console.Write("Enter password: ");
                        var passwordInput = Console.ReadLine();

                        var user = context.Users.FirstOrDefault(i => i.Login == loginInput && i.Password == passwordInput);
                        if (user != null)
                        {
                            Console.WriteLine("Success!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid login or password ");
                        }
                    }
                    

                }
            }

            

        }
    }
}
