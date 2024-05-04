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
        int pin;
        string Firstname;
        string Lastname;
        double balance;
        

       

        public cardHolder(int pin, string cardNum, string Firstname, string Lastname, double balance)
        {
            this.pin = pin;
            this.cardNum = cardNum;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.balance = balance;
        }


        public  string getCardNum()  
        { 
            return cardNum;
        } 
        public int getPin()
        { return pin; }

        public string getFirstname()
        {
            return Firstname;
        }

        public string getLastname()
        {
            return Lastname;
        }

        public double getbalance()
        {
            return balance;
        }
        public void setNum(string newcardNum)
        {
            cardNum = newcardNum;
        }

        public void setpin(int newpin)
        {
            pin = newpin;
        }

        public void setFirstname(string newFirstname)
        {
            Firstname = newFirstname;
        }

        public void setLastname(string newLastname)
        {
            Lastname = newLastname;
        }

        public void setbalance(double newbalance)
        {
            balance = newbalance;
        }


        
    }
}
