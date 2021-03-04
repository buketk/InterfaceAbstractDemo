using GameDemo1.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Concrete
{
    public class CampaignManager: ICampaignService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float DiscountRate { get; set; }

        public void Add(CampaignManager campaignManager)
        {
            throw new NotImplementedException();
        }

        public void Delete(CampaignManager campaignManager)
        {
            throw new NotImplementedException();
        }

        public void Update(CampaignManager campaignManager)
        {
            throw new NotImplementedException();
        }
    }
}
