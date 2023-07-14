using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Genre : IGenre
    {
        public void ShowGenre(string genre)
        {
            Console.WriteLine($"The genre of this club is {genre}");
        }
    }
}
