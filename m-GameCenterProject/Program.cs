﻿using m_GameCenterProject.Abstracts;
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
            //gamerManager.Add(new Gamer { DateOfBirth = new DateTime(1985, 3, 21), FirstName = "Ufuk", LastName = "Altay", NationalityId = 54331490504});


            Gamer gamer1 = new Gamer()
            {
                FirstName = "Ufuk",
                LastName = "ALTAY",
                DateOfBirth = new DateTime(1985, 3, 21),
                NationalityId = 54331490504,
                Id = 1
            };

            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            
            Console.ReadLine();
        }
    }
}
