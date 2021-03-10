using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    
    class OrderManager:IOrderService
    {
        CampaignManager _campaignManager;

        public OrderManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Calculate()
        {
            Console.WriteLine("Toplam Tutar Hesaplandı.");
        }
    }
}
