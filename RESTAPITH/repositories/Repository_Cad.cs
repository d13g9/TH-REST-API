using RESTAPITH.repositories.Interface;
using RESTAPITH.Model;
using System.Collections.Generic;

namespace RESTAPITH.repositories
{
    public class Repository_Cad : IRepository_TH_Cad
    {
        private string strQuery = string.Empty;
        public IList<AddressProfile> Cad_Endereco()
        {
            strQuery = "";
            IList<AddressProfile> objListEndereco;
            return objListEndereco;
        }
        public IList<Jobs> ListaCargos()
        {
            strQuery = "";
            IList<Jobs> objListCargos;
            return objListCargos;
        }
        public IList<PeopleProfile> Cad_Pessoas()
        {
            strQuery = "";
            IList<PeopleProfile> objListPessoas;
            return objListPessoas;
        }
    }
}