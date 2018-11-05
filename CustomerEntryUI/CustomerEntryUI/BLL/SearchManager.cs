using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using CustomerEntryUI.DAL;

namespace CustomerEntryUI.BLL
{
    public class SearchManager
    {

        public bool CheckInfo(SearchCustomerInfo searchObj)
        {
            SearchRipository searchRipoObj=new SearchRipository();
            bool checkInfo = searchRipoObj.CheckInfo(searchObj);
            return checkInfo;
        }
        public DataTable  SearchInfo(SearchCustomerInfo searchObj)
        {
            SearchRipository searchRipoObj=new SearchRipository();
            DataTable searchInfo = searchRipoObj.SearchInfo(searchObj);
            return searchInfo;
        }
    }
}
