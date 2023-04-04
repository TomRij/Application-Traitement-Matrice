using System;

namespace _5TTI_ApplicationTraitementMatriceBON_RijckaertTom
{
    class Program
    {
        static void Main(string[] args)
        {
            MrthodeDuProjet mesProgramme = new MrthodeDuProjet();

            Console.WriteLine("Quel est le nombre de ligne ? (non nulle et supérieur) ");
            int nbLigne = int.Parse(Console.ReadLine());  // récupération du nombre de ligne
            Console.WriteLine("Quel est le nombre de colonne ? (non nulle et supérieur) "); 
            int nbColonne = int.Parse(Console.ReadLine()); // récupération de nombre de colonne

            // appele du morceau de programme permetant de générer le tableau
            mesProgramme.Generation_Tableau(nbLigne, nbColonne, out int[,] tabAlea);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("Taper 1 pour concaténer le tableau\nTaper 2 pour réaliser une addition de deux tableau\nTaper 3 pour réaliser une multiplication de deux tableaux");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
