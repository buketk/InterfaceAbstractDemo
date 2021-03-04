using GameDemo1.Business.Abstract;
using GameDemo1.Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Concrete
{
    public class PlayerManager : IRegistrationService,IPlayerService, IPlayerCheckService
    {

        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync((new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(player.NationalIdenty, player.FirstName, player.LastName, player.DateofBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public bool RegistrationCheck(Player player)
        {
            return true;
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }


    }
}
