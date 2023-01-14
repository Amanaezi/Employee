using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Manager : BonusEmployee
    {
        public override double GetSalary(int days)
        {
            return base.GetSalary(days) + Bonus * SalesVolume;
        }
    }
}
