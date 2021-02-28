using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void SaleDiscount(Game game1, Gamer gamer1, Campaign campaign)
        {
            Console.WriteLine(game1.GameName + " " + "adlı oyun" + gamer1.FirstName + "adlı kişiye"+ " " + campaign.DiscountRate * game1.GamePrice + " TL'ye satışı gerçekleştirildi");
        }
        public void SalePrice(Game game1, Gamer gamer1, Campaign campaign)
        {
            Console.WriteLine(game1.GameName + " adlı oyun " + gamer1.FirstName + " adlı kişiye" + game1.GamePrice + "TL'ye %50 indirim uygulanarak satışı gerçekleştirildi");
        }
    }
}
