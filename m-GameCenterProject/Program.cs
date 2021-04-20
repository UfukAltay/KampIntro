using m_GameCenterProject.Abstracts;
using m_GameCenterProject.Adapters;
using m_GameCenterProject.Concrete;
using m_GameCenterProject.Entities;
using System;

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

            //Console.WriteLine("**************************************");
            //Console.WriteLine("Nasıl devam etmek istersiniz ?");
            //Console.WriteLine("Oyuncu eklemek için (1)");
            //Console.WriteLine("Oyuncu güncelleme için (2)");
            //Console.WriteLine("Oyuncu silme için (3)");

            //int tercih = Convert.ToInt32(Console.ReadLine());

            //switch (tercih)
            //{
            //    case 1:
            //        Console.WriteLine("Oyuncu Ekleme seçildi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Oyuncu Güncelleme seçildi");
            //        break;
            //    case 3:
            //        Console.WriteLine("Oyuncu Silme seçildi");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış seçim yaptınız");
            //        break;
            //}

            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            Console.WriteLine("**************************************");


            GameManager gameManager = new GameManager();
            Game game1 = new Game() { GameId = 1, GameName = "Mario", GamePrice = 100 };
            Game game2 = new Game() { GameId = 2, GameName = "Snake", GamePrice = 50 };
            Game game3 = new Game() { GameId = 3, GameName = "Space Impact", GamePrice = 30 };

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Delete(game2);
            gameManager.Update(game3);


            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign() { CampaignId=1, CampaignName="Efsane Cuma", CampaignDiscount=15 };
            Campaign campaign2 = new Campaign() { CampaignId=2, CampaignName="Şahane Kasım", CampaignDiscount=20 };

            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);


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
