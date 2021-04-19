using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Abstracts
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu eklendi");
            Console.WriteLine("**************************************");
            Console.WriteLine("Adı soyadı : " + gamer.FirstName + " " + gamer.LastName);
            Console.WriteLine("Doğum yılı : " + gamer.DateOfBirth);
            Console.WriteLine("T.C. Kimlik No : " + gamer.NationalityId);
            Console.WriteLine("Oyuncu Id : " + gamer.Id);
            Console.WriteLine("**************************************");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu silindi");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu güncellendi");
        }
    }
}
