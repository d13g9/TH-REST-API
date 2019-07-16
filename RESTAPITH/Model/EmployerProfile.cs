using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class EmployerProfile : BaseProfile
    {
        private long Id { get; set; }
        private string CNPJ { get; set; }

        public ICollection<Vagas> vagas_publicadas { get; set; }
    }
}
