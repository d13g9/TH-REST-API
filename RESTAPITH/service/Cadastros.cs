using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPITH.Model;

namespace RESTAPITH.service
{
    public class Cadastros 
    {
        private readonly PeopleProfile _peoples;
        private readonly AddressProfile _address;

        IList<AddressProfile> Cad_Endereco()
        {
            return (IList<AddressProfile>)_address;
        }
        IList<PeopleProfile> Cad_Pessoas()
        {
            return (IList<PeopleProfile>)_peoples;
        }
    }
}