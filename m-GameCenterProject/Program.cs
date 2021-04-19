using m_GameCenterProject.Abstracts;
using m_GameCenterProject.Adapters;
using m_GameCenterProject.Concrete;
using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;

namespace m_GameCenterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());

            Gamer gamer1 = new Gamer()
            {
                FirstName = "Ufuk",
                LastName = "ALTAY",
                DateOfBirth = 1985,
                NationalityId = 54331490504,
                Id = 1
            };
            gamerManager.Add(gamer1);


            //OyuncuEkle(gamerManager);

            Console.WriteLine("**************************************");
            Console.WriteLine("Nasıl devam etmek istersiniz ?");
            Console.WriteLine("Oyuncu eklemek için (1)");
            Console.WriteLine("Oyuncu güncelleme için (2)");
            Console.WriteLine("Oyuncu silme için (3)");

            int tercih = Convert.ToInt32(Console.ReadLine());

            switch (tercih)
            {
                case 1:
                    Console.WriteLine("Oyuncu Ekleme seçildi");
                    break;
                case 2:
                    Console.WriteLine("Oyuncu Güncelleme seçildi");
                    break;
                case 3:
                    Console.WriteLine("Oyuncu Silme seçildi");
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız");
                    break;
            }


            //gamerManager.Update(gamer1);
            //gamerManager.Delete(gamer1);

            Console.ReadLine();
        }

        private static void OyuncuEkle(BaseGamerManager gamerManager)
        {
            Gamer gamer1 = new Gamer();

            gamer1.Id = 1;
            Console.Write("Oyuncu adını giriniz : ");
            gamer1.FirstName = Console.ReadLine().ToUpper();
            Console.Write("Oyuncu soyadını giriniz : ");
            gamer1.LastName = Console.ReadLine().ToUpper();
            Console.Write("Oyuncunun doğum yılını giriniz : ");
            gamer1.DateOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncunun T.C. Kimlik Numarasını giriniz : ");
            gamer1.NationalityId = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("**************************************");

            gamerManager.Add(gamer1);
        }
    }
}
