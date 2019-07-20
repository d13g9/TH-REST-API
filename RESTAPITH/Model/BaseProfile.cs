using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public abstract class BaseProfile
    {
        private string name;
        private string telephone;
        public string Name {
            get => name;
            set => name = value;
        }
       
        public string Telephone {
            get => telephone;
            set => telephone = value;
        }
    }
}
