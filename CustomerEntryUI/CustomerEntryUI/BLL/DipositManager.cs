using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using CustomerEntryUI.DAL;

namespace CustomerEntryUI.BLL
{
    public class DipositManager
    {
        DipositRipository dipositRipObj = new DipositRipository();
        public bool CheckInfo(TransactionInfo dipositObj)
        {
            bool checkInfo = dipositRipObj.CheckInfo(dipositObj);
            return checkInfo;
        }


        public bool DipositInfo(TransactionInfo dipositObj)
        {
            bool dipositInfo = dipositRipObj.DipositInfo(dipositObj);
            return dipositInfo;
        }

       
    }
}
