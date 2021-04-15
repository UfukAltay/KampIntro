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
            Console.WriteLine(gamer.FirstName +  " adlı oyuncu eklendi");
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
