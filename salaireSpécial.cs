using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class salaireSpécial : Personne
    {

        public int HoursWorked;

        public salaireSpécial(int hoursWorked)
        {
            HoursWorked = hoursWorked;
        }

        public override float CalculerSalaire()
        {
            return base.salaire * 12 + this.HoursWorked * 8;
        }
    }
}
