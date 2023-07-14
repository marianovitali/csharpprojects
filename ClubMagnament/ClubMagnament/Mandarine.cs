using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMagnament;

namespace ClubMagnament
{
    public class Mandarine : IClub
    {
        private string _genreOfTheClub = "Trance";
        private string _nextGigs = "Bryan Kearney 14/07 \n John O'Callaghan 22/08 \n Armin Van Buuren 29/08";
        private int _security = 12;
        private readonly IGenre _genre;
        private readonly IGig _gig;
        private readonly IStaff _staff;
        public Mandarine(IGenre genre, IGig gig, IStaff staff)
        {
            _genre = genre;
            _gig = gig;
            _staff = staff;
        }

        public void ShowInfo()
        {
            Console.WriteLine("This is Mandarine Club");
            _genre.ShowGenre(_genreOfTheClub);
            _gig.NextGigs(_nextGigs);
            _staff.ShowStaff(_security);
        }

    }
}
