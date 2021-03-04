using GameDemo1.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(CampaignManager campaignManager);
        void Update(CampaignManager campaignManager);
        void Delete(CampaignManager campaignManager);

    }
}
