using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMagnament
{
    public class Security : IStaff
    {
        private int _incomeOfSecurityGuard = 700;
        private readonly IIncome _income;

        public Security(IIncome income)
        {
            _income = income;
        }

        public void ShowStaff(int security)
        {
            Console.WriteLine($"This club has {security} Security Guards");
            _income.CalculateIncome(_incomeOfSecurityGuard);
        }
    }
}
