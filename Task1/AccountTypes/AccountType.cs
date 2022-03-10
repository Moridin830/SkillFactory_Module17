using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class AccountType:ICalculateInterest, ITypeOperations
    {
        public void ChangeType(Account account, AccountType type)
        {
            account.Type = type;
        }

        public abstract void CalculateInterest(Account account);
    }
}
