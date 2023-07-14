using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Gig : IGig
    {
        public void NextGigs(string gigs)
        {
            Console.WriteLine($"The next gigs in this club are: \n {gigs}");
        }

    }
}
