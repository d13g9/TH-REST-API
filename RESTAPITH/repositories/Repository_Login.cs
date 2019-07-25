using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RESTAPITH.repositories.Interface;
using RESTAPITH.Model;

namespace RESTAPITH.repositories
{
    public class Repository_TH : IRepository_TH_Login
    {
        private string strQuery = string.Empty;
        public bool LoginApp(string parmEmail, string parmSenha)
        {
            strQuery = "";
            return true;
        }
    }
}
