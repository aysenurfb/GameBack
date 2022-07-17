using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBack.Entities;
using GameBack.Interface;

namespace GameBack.Concreate
{
    public class SalesManager : ISalesService
    {
        public void Add(Sales sale)
        {
            Console.WriteLine("----------Sales details----------\nCustomer: " + sale.GamerName+ "\nGame: " + sale.NameOfGame+ "\nCampaign that Gamer use: "+sale.CampaignName + "\nPrice: " + sale.Price);
        }
    }
}
