using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void SalePrice(Game game, Gamer gamer, Campaign campaign); //sale price : satış fiyatı
        void SaleDiscount(Game game, Gamer gamer, Campaign campaign); // sale discount : satış indirimi
    }
}
