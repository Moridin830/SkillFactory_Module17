using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PayrollType:AccountType
    {
        public override void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
