using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBack.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string GamerName { get; set; }
        public string NameOfGame { get; set; }
        public double PercentOfSale { get ;set ; }
        public string CampaignName { get; set; }

    }
}
