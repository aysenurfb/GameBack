using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBack.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignFinishDate { get; set; }
        public double PercentOfSale { get; set; }
    }
}
