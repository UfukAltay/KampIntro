using m_GameCenterProject.Abstracts;
using m_GameCenterProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellendi");
        }
    }
}
