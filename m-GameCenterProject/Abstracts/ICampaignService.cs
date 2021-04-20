using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Abstracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
