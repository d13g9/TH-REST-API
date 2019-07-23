using System.Collections.Generic;
using RESTAPITH.Model;

namespace RESTAPITH.service.Interface
{
    public interface ILoginService
    {
        /// <summary>
        /// TRATA LOGIN DO USUÁRIO NO APLICATIVO
        /// </summary>
        /// <returns></returns>
        bool ILoginApp();
        IList<RESTAPITH.Model.AddressProfile> ICad_Endereco();
        IList<RESTAPITH.Model.Jobs> IListaCargos();
        IList<RESTAPITH.Model.PeopleProfile> ICad_Pessoas();
    }
}