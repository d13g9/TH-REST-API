using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    /// <summary>
    /// Vagas - que o empregador vai divulgar
    /// obs: idVagas deve ser o mesmo Id dentro de jobTitles
    /// </summary>
    public class Jobs
    {
        public long IdVagas { get; set; }
        public string strDescricao { get; set; }
        public string strObservacoes { get; set; }
        public DateTime dtDivulgacao { get; set; }
        public DateTime dtCriacao { get; set; }
    }
}
