using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("1", "2", "3");
            bankAccount.ActivateAccount();
            
            
        }
    }
}
