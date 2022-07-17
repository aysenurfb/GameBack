using System;
using GameBack.Concreate;
using GameBack.Adapters;
using GameBack.Entities;
using GameBack.Interface;

namespace GameBack
{
    class Program
    {
        static void Main(string[] args)
        {
            //gercek verilerle calısmaktadır
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Ayşe Nur";
            gamer1.LastName = "Aktepe";
            gamer1.UserName = "kahajs13";
            gamer1.Password = "23";
            gamer1.NationalityId = "***********";
            gamer1.DateOfBirthOfGamer = new DateTime(1989,12,13);

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);

            
            Campaign campaign1 = new Campaign();
            campaign1.Id = 12;
            campaign1.CampaignName = "Christmas";
            campaign1.CampaignStartDate = new DateTime(2020, 12, 12);
            campaign1.CampaignFinishDate = new DateTime(2021, 1, 1);
            campaign1.PercentOfSale=0.2;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            

            Sales sales1 = new Sales();
            sales1.Id = 1;
            sales1.Price = 80;
            sales1.GamerName = "Ayşe Nur";
            sales1.NameOfGame = "Assassin's Creed Valhalla";
            sales1.PercentOfSale = 0.2;
            sales1.CampaignName = "Christmas";

            SalesManager salesManager = new SalesManager();
            salesManager.Add(sales1);
        }
    }
}
