using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    /// <summary>
    /// ACESSO AO APLICATIVO
    /// </summary>
    public class LoginProfile
    {
        public long IdPessoa { get; set; }
        public String email { get; set; }
        public String password { get; set; }
       
    }
}
