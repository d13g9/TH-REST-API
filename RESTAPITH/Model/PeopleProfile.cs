using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    /// <summary>
    /// USUARIOS - cadastro dos dados do usuário
    /// </summary>
    public class PeopleProfile
    {
        public long IdPessoa { get; set; }
        public string CNPJ_CPF { get; set; }
        public string strNome { get; set; }
        public long IdEndereco { get; set; }
        public string strCelular { get; set; }
        public long IdVagas { get; set; }
        public long IdCargo { get; set; }
        public DateTime dtNascimento { get; set; }
        public DateTime dtCriacao { get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
