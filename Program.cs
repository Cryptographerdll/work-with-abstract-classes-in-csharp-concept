using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            salaireSpécial S1 = new salaireSpécial(10)
            {
                nom = "khalid",
                prenom = "bouhousse",
                salaire = 1000
            };

            Console.WriteLine("Le nom Complet est: {0}\n", S1.NomComplet());

                Console.WriteLine("Le annuel salaire est: "+ S1.CalculerSalaire());
        }
    }
}
