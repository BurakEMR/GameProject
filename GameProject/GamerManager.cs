using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        public void Sign(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Gerçekleştirildi");
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Eklendi");  
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Başarıyla Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Başarıyla Güncellendi");
        }
    }
}
