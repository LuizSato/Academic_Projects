using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSample
{
    [Serializable]
    public class CheckingAccount : Account
    {
        public double MonthlyFee { get; set; }
        public CheckingAccount(string accountNumber, double monthlyFee) : base(accountNumber)
        {
            MonthlyFee = monthlyFee;
        }
        public CheckingAccount() { }
        public double ReturnMonthlyFee()
        {
            return MonthlyFee;
        }
    }
}
