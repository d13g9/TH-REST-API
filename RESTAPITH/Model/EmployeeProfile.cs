using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class EmployeeProfile : BaseProfile
    {
        public long Id { get; set;}
        public string cpf { get; set; }

        public ICollection<Applyances> vagas_publicadas { get; set; }
    }
}
