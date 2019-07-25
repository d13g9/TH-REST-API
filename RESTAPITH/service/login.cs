using System;
using System.Collections.Generic;
using System.Linq;

using RESTAPITH.Model;
using RESTAPITH.service.Interface;

namespace RESTAPITH.service
{
    public class login : IServices_Login 
    {
        private readonly login _login;

        public bool LoginApp(string parmEmail, string parmSenha)
        {
            throw new NotImplementedException();
        }
    }
}