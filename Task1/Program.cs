using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account payrollAccount = new Account(new PayrollType(), 100);
            Account account = new Account(new BasicTypeUnder1000(), 2000);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            
        }
    }
}
