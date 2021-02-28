using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "BURAK";
            gamer1.LastName = "EMİR";
            gamer1.NationalityId = "0123456789";

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "ENES";
            gamer2.LastName = "ZABIN";
            gamer2.NationalityId = "9876543210";

            gamerManager.Sign(gamer1);
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

           
            Game game1 = new Game();
            game1.GameId =  1;
            game1.GameName = "PUBG";
            game1.GamePrice = 87;
            

            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "CSGO";
            game2.GamePrice = 120;

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            campaign.CampaignId = 3;
            campaign.CampaignName = "BAHAR DÖNEMİ İNDİRİMİ";
            campaign.DiscountRate = 0.50M;

            SaleManager saleManager = new SaleManager();
            saleManager.SalePrice(game1, gamer1, campaign);
            saleManager.SaleDiscount(game2, gamer2, campaign);
            
        }
    }
}
