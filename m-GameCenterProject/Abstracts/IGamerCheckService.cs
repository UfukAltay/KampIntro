using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Abstracts
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
