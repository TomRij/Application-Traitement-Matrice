using System;

namespace _5TTI_ApplicationTraitementMatrice_RijckaertTom
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeDuProjet mesProgramme = new MethodeDuProjet();

            Console.WriteLine("Quel est le nombre de ligne ? (non nulle et supérieur) ");
            // variable demandant à l'utilisateur le nombre de ligne de la matrice
            int nbLigne = int.Parse(Console.ReadLine());
            Console.WriteLine("Quel est le nombre de colonne ? (non nulle et supérieur) ");
            // variable demandant à l'utilisateur le nombre de colonne de la matrice
            int nbColonne = int.Parse(Console.ReadLine());

            // appele du morceau de programme permetant de générer le tableau
            mesProgramme.Generation_Tableau(nbLigne, nbColonne, out int[,] tabAlea);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLigne("Taper 1 pour concaténer le tableau\nTaper 2 pour réaliser une addition de deux tableau\nTaper 3 pour réaliser une multiplication de deux tableaux");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
