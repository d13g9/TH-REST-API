using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    /// <summary>
    /// Cargos - que colaboradores e empregador vão estar associados
    /// </summary>
    public class JobTitles
    {
        public long IdCargo { get; set; }
        public string strDescriao { get; set; }
        public DateTime dtCriacao { get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
