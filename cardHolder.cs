using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class cardHolder
    {
        public string cardNum;
        public int pin;
        public string firstName;
        public string lastName;
        double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        { 
            return cardNum; 
        }
        public void setNum(string newcardNum) 
        {
            cardNum = newcardNum;
        }
        public int getPin() 
        {
            return pin;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public string getFirstName() 
        {
            return firstName;
        }
        public void setFirstName(string newfirstName) 
        {
            firstName = newfirstName;
        }
        public string getLastName() 
        {
            return lastName;
        }

        public void setLastname(string newlastName)
        {
            lastName = newlastName;
        }

        public double getBalance()
        { return balance; }

        public void setBalance(double newbalance)
        {
            balance = newbalance;
        }
    }

}
