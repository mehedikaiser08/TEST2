using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.DAL;
using CustomerEntryUI.Models;


namespace CustomerEntryUI.BLL
{
    public class WithdrawManager
    {
        public string WithdrawInfo(TransactionInfo withdrawObj)
        {
            WithdrawRipository withRipoObj=new WithdrawRipository();
            string withdrawInfo = withRipoObj.WithdrawInfo(withdrawObj);
            return withdrawInfo;
        }
    }
}
