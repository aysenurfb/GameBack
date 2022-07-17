using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBack.Entities;

namespace GameBack.Interface
{
    public interface ICampaignService
    {
        public void Add(Campaign campaign) { }

        public void Update(Campaign campaign) { }

        public void Delete(Campaign campaign) { }
    }
}
