using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
   abstract class Personne
    {
        public string prenom, nom;
        public float salaire;

        public string NomComplet()
        {
            return this.prenom + this.nom;
        }

        public abstract float CalculerSalaire(); 
    }
}
