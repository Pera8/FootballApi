using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class FootballClub
    {
        public int Id { get; set; }
        public string ClubName { get; set; }
        public List<Player> Players { get; set; }
    }
}
