using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class BankAccount
    {
        private List<string> userInfo = new List<string>();
        private bool status = false;
        private decimal balance = 0;
        DateTime createDate;
        public BankAccount(string firstName, string lastName, string midName)
        {
            userInfo.Add(firstName);
            userInfo.Add(lastName);
            userInfo.Add(midName);
            createDate = DateTime.Now;

        }
        public DateTime CreateDate
            {get; }

        public bool Status
        {
            get { return this.status; }
            
        }
        public decimal Balance
        { get; }
        public void ActivateAccount()
        {
            if (this.status == true)
            {
                Console.WriteLine("Чувак, ты упоролся?Твоя сраная карта активна(ты лох)!");
            }
            else
            {
                this.status = true;
            }
        }
        public void BlockedAccount()
        {
            if (this.status == false)
            {
                Console.WriteLine("Чувак, ты упоролся?Твоя сраная карта уже заблокирована!");
            }
            else
            {
                this.status = false;
            }
        }
        public void Deposit(decimal countCash)
        {
            if(countCash<=0)
            {
                Console.WriteLine("Неверно указана сумма:(лошара");
                
            }
            else
            {
                balance += countCash;
                
            }
            
        }

        public void Spending(decimal countSpandingCash)//расход средств
        {
            if (this.Status == false)//проверка на блокировку
            {
                Console.WriteLine("Аккаунт заблокирован!");

            }

            else
            {
                if (countSpandingCash > balance)
                {
                    Console.WriteLine("Недостаточно средств на счете, пожалуйста пополните счет.");
                }
                else
                {
                    balance -= countSpandingCash;

                }
            }
        }
    }
}
