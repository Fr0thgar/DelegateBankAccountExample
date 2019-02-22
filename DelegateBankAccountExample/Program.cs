﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankAccountExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account NikolajsAccount = new Account();

            NikolajsAccount.AccountDeposit = NikolajsAccount.DepositNoAlerts;
            Console.WriteLine(NikolajsAccount.AccountDeposit(20000));
            Console.WriteLine("saldo: " + NikolajsAccount.Saldo);

            NikolajsAccount.AccountDeposit = NikolajsAccount.DepositMoneyLaundryAlert;
            Console.WriteLine(NikolajsAccount.AccountDeposit(20000));
            Console.WriteLine("saldo: " + NikolajsAccount.Saldo);




        }
    }
}
