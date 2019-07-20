using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class AddressProfile
    {
        public long IdEndereco { get; set;}
        public string strEndereco { get; set; }
        public DateTime dtCriacao { get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
