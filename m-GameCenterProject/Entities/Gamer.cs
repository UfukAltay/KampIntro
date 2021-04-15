using System;
using System.Collections.Generic;
using System.Text;

namespace m_GameCenterProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
