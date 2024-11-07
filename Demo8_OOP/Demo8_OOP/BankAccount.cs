using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_OOP
{
    public class BankAccount
    {
        //defining the properties
        public string AccNum;
        public string HolderName;
        public string Pin;
        public double Balance;

        //behaviour/actions
        public string GetData()
        {
            return "Acc Num: " + AccNum +
                   " Holder Name: " + HolderName +
                   " Pin: " + Pin +
                   " Balance: " + Balance;
        }

        public void Deposit(double amt)
        {
            Balance += amt;
            //OR
            //Balance = Balance + amt;
        }
    }
}
