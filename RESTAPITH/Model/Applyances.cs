using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class Applyances
    {
        [Key,Column(Order = 1)]
        public long Id_Employee { get; set; }
        [Key, Column(Order = 2)]
        public long Id_Vaga { get; set; }
        public long Applyances_id { get; set; }
        public Vagas vaga { get; set; }
        public EmployeeProfile employee {get; set;}
    }
}
