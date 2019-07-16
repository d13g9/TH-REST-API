using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class Vagas
    {
        private long Id { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }

        public EmployeeProfile ep { get; set; }
        public ICollection<Applyances> vagas_publicadas { get; set; }
    }
}
