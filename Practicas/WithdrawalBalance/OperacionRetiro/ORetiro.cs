using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WithdrawalBalance.OperacionRetiro
{
    public class ORetiro
    {
        SWBalance.SWBalance balance = new SWBalance.SWBalance();
        SWWithdrawal.SWWithdrawal withdrawal = new SWWithdrawal.SWWithdrawal();
        public double withdrawalBalance(double n2, double n1 = 1500 )
        {
            if(n2<= n1) {
                double aux = withdrawal.Retiro(balance.Balance(n1), n2);
                return balance.Balance(aux);
            }
            else
            {
                return -1;
            }
        }
    }
}