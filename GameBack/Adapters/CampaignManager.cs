using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBack.Interface;
using GameBack.Entities;

namespace GameBack.Adapters
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign) 
        {
            Console.WriteLine( campaign.CampaignName+" Campaign added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign updated");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign deleted");
        }
    }
}
