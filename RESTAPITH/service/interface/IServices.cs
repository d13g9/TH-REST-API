using System.Collections.Generic;
using RESTAPITH.Model;

namespace RESTAPITH.service.Interface
{
    public interface IServices
    {
        /// <summary>
        /// TRATA LOGIN DO USUÁRIO NO APLICATIVO
        /// </summary>
        /// <returns></returns>
        bool ILoginApp();
        IList<AddressProfile> ICad_Endereco();
        IList<Jobs> IListaCargos();
        IList<PeopleProfile> ICad_Pessoas();
    }
}