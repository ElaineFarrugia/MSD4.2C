using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Demo8_OOP
{
    public class BankAccount
    {
        //defining the properties
        public string AccNum;
        public string HolderName;
        public string Pin;
        public double Balance;

        //constructor
        public BankAccount(string _accNum,
                           string _HolderName, 
                           string _Pin,
                           double _Balance)
        {
            AccNum = _accNum;
            HolderName = _HolderName;
            Pin = _Pin;
            Balance = _Balance;
        }

        public BankAccount() { } //parameter-less

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

        public bool Withdraw(double amt)
        {
            if (Balance >= amt)
            {
                Balance -= amt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
