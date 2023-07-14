using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Bartender : IStaff
    {
        private int _incomeOfBarTender = 800;
        private readonly IIncome _income;

        public Bartender(IIncome income)
        {
            _income = income;
        }

        public void ShowStaff(int bartender)
        {
            Console.WriteLine($"This club has {bartender} Bar Tenders");
            _income.CalculateIncome(_incomeOfBarTender);
        }
    }
}
