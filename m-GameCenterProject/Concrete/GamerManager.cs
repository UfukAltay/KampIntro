using m_GameCenterProject.Abstracts;
using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Kişi geçerli değil");
            }
        }
    }
}
