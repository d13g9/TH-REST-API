using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    /// <summary>
    /// Vinculo entre Colaborador e seus possiveis cargos
    /// </summary>
    public class EmployeeJobs
    {
        public long IdPessoa { get; set; }
        public long IdCargo { get; set; }
    }
}
