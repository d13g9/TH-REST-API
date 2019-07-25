using System.Collections.Generic;
using RESTAPITH.Model;

namespace RESTAPITH.service.Interface
{
    public interface IServices_Cad
    {
        IList<AddressProfile> Cad_Endereco();
        IList<Jobs> ListaCargos();
        IList<PeopleProfile> Cad_Pessoas();
    }
}