using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class Secreatary: Employee
    {

        public bool Certified { get; set; }

        public Secreatary(bool certified, int baseSalary, int id, string name, string mobile) : base(baseSalary, id, name, mobile)
        {
            Certified = certified;
        }

        public override double CalculateSalary()
        {
            if (Certified)
            {
                return _baseSalary * 3; 
            }
            else
            {
                return _baseSalary;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"  {(Certified ? "Er certificeret" : "Er ikke certificeret") }";
        }

        public override double CalculatePension()
        {
            return 0.2 * _baseSalary;
        }
    }
}
