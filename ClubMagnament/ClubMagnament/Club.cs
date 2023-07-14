using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Club
    {
        private readonly IClub _club;
        
        public Club(IClub club)
        {
            _club = club;
        }

        public void ShowInfo()
        {
            _club.ShowInfo();
        }
    }
}
