using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Crobar : IClub
    {
        private string _genreOfTheClub = "Techno";
        private string _nextGigs = "Ambivalent 14/07 \n Richie Hawtin 22/08 \n Amelie Lens 29/08";
        private int _security = 14;
        private readonly IGenre _genre;
        private readonly IGig _gig;
        private readonly IStaff _staff;
        public Crobar(IGenre genre, IGig gig, IStaff staff)
        {
            _genre = genre;
            _gig = gig;
            _staff = staff;
        }

        public void ShowInfo()
        {
            Console.WriteLine("This is Crobar BA");
            _genre.ShowGenre(_genreOfTheClub);
            _gig.NextGigs(_nextGigs);
            _staff.ShowStaff(_security);
        }
    }
}
