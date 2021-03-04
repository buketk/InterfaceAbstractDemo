using GameDemo1.Business.Concrete;
using GameDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Abstract
{
    public interface ISalesService
    {
        List<CampaignManager> GetList()
        {
            return null;
        }

        void Buy(Player player);
    }
}
