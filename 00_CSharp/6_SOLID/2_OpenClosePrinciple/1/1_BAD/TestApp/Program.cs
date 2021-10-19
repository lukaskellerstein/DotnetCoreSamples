using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Account
    {
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        // members and function declaration
        public decimal CalcInterest(string accType)
        {

            if (accType == "Regular") // savings //<-- THIS IS WRONG => NEEDS MODIFICATION
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // salary savings //<-- THIS IS WRONG => NEEDS MODIFICATION
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate //<-- THIS IS WRONG => NEEDS MODIFICATION
            {
                Interest = (Balance * 3) / 100;
            }
            return Interest;
        }
    }
}
