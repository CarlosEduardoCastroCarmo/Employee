using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Entities
{
    class OutsourceEmployee : Employees
    {
        public double AdicionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double adicionalCharge) :
            base(name, hours, valuePerHour)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdicionalCharge;
        }

    }
}
