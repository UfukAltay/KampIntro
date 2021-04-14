using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Abstracts
{
    public abstract class BaseGamerManager
    {
        public virtual void Add(Entities.Gamer gamer)
        {
            Console.WriteLine("Oyuncu eklendi");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
