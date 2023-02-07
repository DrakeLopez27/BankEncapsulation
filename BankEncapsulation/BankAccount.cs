using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
     private readonly double balance;    
        
        public void Deposit(double amount)
        {
             amount += balance;
        }
        public double GetBalance() 
        { 
            return balance;
        }

    }
    
    
    

    
    


}
