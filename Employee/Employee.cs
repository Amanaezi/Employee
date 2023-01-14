using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public abstract class Employee
    {
        public string Name { get; set; } = "NoName";
        public double Rank { get; set; }

        public virtual double GetSalary(int days) => Rank * days;
    }
}
