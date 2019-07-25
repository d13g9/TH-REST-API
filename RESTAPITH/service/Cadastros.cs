using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RESTAPITH.Model;
using RESTAPITH.service.Interface;

namespace RESTAPITH.service
{
    public class Cadastros : IServices_Cad
    {
        private readonly PeopleProfile _peoples;
        private readonly AddressProfile _address;

        public IList<AddressProfile> Cad_Endereco()
        {
            throw new NotImplementedException();
        }

        public IList<PeopleProfile> Cad_Pessoas()
        {
            throw new NotImplementedException();
        }

        public IList<Jobs> ListaCargos()
        {
            throw new NotImplementedException();
        }
    }
}