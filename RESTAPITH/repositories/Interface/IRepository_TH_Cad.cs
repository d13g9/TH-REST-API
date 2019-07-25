using System.Collections.Generic;
using RESTAPITH.Model;

namespace RESTAPITH.repositories.Interface
{
    public class IRepository_TH_Cad
    {
        IList<AddressProfile> Cad_Endereco();
        IList<Jobs> ListaCargos();
        IList<PeopleProfile> Cad_Pessoas();
    }
}
