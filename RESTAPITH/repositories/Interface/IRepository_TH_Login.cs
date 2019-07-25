using RESTAPITH.Model;
using System.Collections.Generic;

namespace RESTAPITH.repositories.Interface
{
    interface IRepository_TH_Login
    {
        bool LoginApp(string parmEmail, string parmSenha);
    }
}