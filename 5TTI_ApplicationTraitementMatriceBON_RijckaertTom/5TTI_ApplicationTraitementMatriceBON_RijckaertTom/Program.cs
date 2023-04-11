using System;

namespace _5TTI_ApplicationTraitementMatriceBON_RijckaertTom
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MrthodeDuProjet mesProgramme = new MrthodeDuProjet();

                Console.WriteLine("Quel est le nombre de ligne ? (non nulle et supérieur) ");
                int nbLigne = int.Parse(Console.ReadLine());  // récupération du nombre de ligne
                Console.WriteLine("Quel est le nombre de colonne ? (non nulle et supérieur) ");
                int nbColonne = int.Parse(Console.ReadLine()); // récupération de nombre de colonne

                // appele du morceau de programme permetant de générer le premier tableau
                mesProgramme.Generation_Tableau(nbLigne, nbColonne, out int[,] tabAlea1);

                mesProgramme.Generation_Tableau(nbLigne, nbColonne, out int[,] tabAlea2);

                string choix = "";
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Taper 1 pour concaténer le tableau\nTaper 2 pour réaliser une addition de deux tableau\nTaper 3 pour réaliser une multiplication de deux tableaux");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Quel tableau voulez-vous concaténer (1 ou 2) : ");
                        int concatener = int.Parse(Console.ReadLine());
                        if (concatener == 1)
                        {
                            mesProgramme.String_Tableau(tabAlea1, out string stringTab);
                            Console.WriteLine(stringTab);
                        }
                        else
                        {
                            mesProgramme.String_Tableau(tabAlea2, out string stringTab);
                            Console.WriteLine(stringTab);
                        }
                        break;

                    case "2":
                        mesProgramme.Addition_Matrices(tabAlea1, tabAlea2, out int[,] tab3Somme, out bool addition);
                        if (addition == true)
                        {
                            mesProgramme.String_Tableau(tab3Somme, out string stringTab);
                            Console.WriteLine("La somme des deux tableaux est : \n" + stringTab);
                        }
                        else
                        {
                            Console.WriteLine("Addition impossible car les tableaux ne sont pas de même taille ! ");
                        }
                        break;

                    case "3":
                        mesProgramme.MultiplicationsMatrice(tabAlea1, tabAlea2, out int[,] matriceMulti, out bool test);
                        if (test == true)
                        {
                            mesProgramme.String_Tableau(matriceMulti, out string stringTab);
                            Console.WriteLine("Le produit des deux tableaux est " + stringTab);
                        }
                        break;


                    default:
                        Console.WriteLine("Vous avez oublié de choisier quelque chose !");
                        break;
                }

                Console.WriteLine("Voulez-vous recommencer : (oui ou non) ");
                string boolChoix = Console.ReadLine();
                if (boolChoix == "non")
                {
                    break;
                }
            }
        }
    }
}
