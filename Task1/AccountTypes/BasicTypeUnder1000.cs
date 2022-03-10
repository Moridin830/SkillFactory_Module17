using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BasicTypeUnder1000:BasicType
    {
        public override void CalculateInterest(Account account)
        {
            account.Interest -= account.Balance * 0.2;
        }
    }
}
