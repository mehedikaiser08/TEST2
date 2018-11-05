using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.DAL;
using CustomerEntryUI.Models;

namespace CustomerEntryUI.BLL
{
    public class RegistrationManager
    {
        RegistrationRepository regiRipoObj = new RegistrationRepository();


        public bool CheckInfo(Registration registrationObj)
        {
            bool sameInfo = regiRipoObj.CheckInfo(registrationObj);
            return sameInfo;
        }
        public bool SaveRegistrationInfo(Registration registrationObj)
        {
            bool registrationInfo = regiRipoObj.SaveRegistrationInfo(registrationObj);
            return registrationInfo;
        }

        
    }
}
