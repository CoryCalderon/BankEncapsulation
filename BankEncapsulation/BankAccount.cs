using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 0;

        public void Deposite(double cashDeposite)
        {
            _balance += cashDeposite;
        }

        public double CheckBalance()
        {
            return _balance;
        }

        
    }




}
