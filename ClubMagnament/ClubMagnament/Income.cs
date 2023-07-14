using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Income : IIncome
    {
        public void CalculateIncome(int income)
        {
            Console.WriteLine($"The aprox income for the staff is ${income}");
        }
    }
}
