using System.Collections.Generic;
using RESTAPITH.Model;

namespace RESTAPITH.service.Interface
{
    public interface IServices_Login
    {
        /// <summary>
        /// TRATA LOGIN DO USUÁRIO NO APLICATIVO
        /// </summary>
        /// <returns></returns>
        bool LoginApp(string parmEmail, string parmSenha);
    }
}