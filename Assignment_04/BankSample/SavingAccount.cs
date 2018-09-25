using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSample
{
    [Serializable]
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount(string accountNumber, double interesetRate) : base(accountNumber)
        {
            InterestRate = interesetRate;
        }
        public SavingAccount() { }
        public double ReturnInterestRate()
        {
            return InterestRate;
        }
    }
}
