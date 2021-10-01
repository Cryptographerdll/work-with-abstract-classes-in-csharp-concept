using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class salaire : Personne
    {
        public override float CalculerSalaire()
        {
            return base.salaire * 12;
        }
    }
}
