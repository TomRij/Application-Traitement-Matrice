using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTI_ApplicationTraitementMatriceBON_RijckaertTom
{
    struct MrthodeDuProjet
    {
        // morceau de programme pour générer les tableaux
        public void Generation_Tableau(int nbLigne, int nbColonne, out int[,] tabAlea)
        {
            // instantiation de la matrice tabAlea
            tabAlea = new int[nbLigne, nbColonne];
            // instantiation de la variable random
            Random alea = new Random();
            // boucle pour passer dans les lignes de la matrice
            for (int ligne = 0; ligne < nbLigne; ligne++)
            {
                // boucle pour passer dans les colonnes de la matrice
                for (int colonne = 0; colonne < nbColonne; colonne++)
                {
                    // mise des données alléatoires comprises entre 1 et 20 dans la matrice 
                    tabAlea[ligne, colonne] = alea.Next(0, 20);
                }
            }
        }
        //morceau de programme pour concaténer (afficher) la matrice
        public void String_Tableau(int[,] Tab, out string stringTab)
        {
            // instanciation de la variable stringTab
            stringTab = "";
            // boucle pour se balades dans les lignes de la matrice
            for (int ligne = 0; ligne < Tab.GetLength(0); ligne++)
            {
                // boucle pour se balader dans les colonnes de la matrice
                for (int colonne = 0; colonne < Tab.GetLength(1); colonne++)
                {
                    // mise des données de la matrice dans la variable string stringTab
                    stringTab += Tab[ligne, colonne] + "|";
                }
                // passage à la ligne
                stringTab += "\n";
            }
        }
        /// <summary>
        /// morceau de programme pour addition 2 matrices
        /// </summary>
        /// <param name="tab1">contient les valeura a aditionner</param>
        /// <param name="tab2">contient les valeurs a additioner</param>
        /// <param name="tab3">contient l’addition de Tab1 et Tab2</param>
        /// <param name="addition">est vrai si on a pu faire l’addition</param>
        public void Addition_Matrices(int[,] tab1, int[,] tab2, out int[,] tab3, out bool addition)
        {
            // instantiation de la variable addition en true
            addition = true;
            // instatiation de la matrice tab3[,] de la taille de tab1 et tab2
            tab3 = new int[tab1.GetLength(0), tab2.GetLength(1)];
            // vérification que tab1 et tab2 dont la même taille
            if (tab1.GetLength(0) == tab2.GetLength(0) && tab1.GetLength(1) == tab2.GetLength(1))
            {
                // boucle se baladant dans les lignes des matrices
                for (int ligne = 0; ligne < tab1.GetLength(0); ligne++)
                {
                    // boucle se baladant dans les colonnes des matrices
                    for (int colonne = 0; colonne < tab2.GetLength(1); colonne++)
                    {
                        // addition de tab1 et tab2 et solution dans tab3
                        tab3[ligne, colonne] = tab1[ligne, colonne] + tab2[ligne, colonne];
                    }
                }
            }
            else
            {
                // renvoie de addition en false
                addition = false;
            }
        }
        /// <summary>
        /// multiplier 2 matrices et renvoyer la multiplications si la multiplications n’est pas possible renvoyer une variable false !! LES MATRICES DOIVENT ÊTRE NON NULLES!!
        /// </summary>
        /// <param name="matrice1">contient la matrice1 a multiplier</param>
        /// <param name="matrice2">contient la matrice2 a multiplie</param>
        /// <param name="matriceMulti">contient la multiplications des deux matrices</param>
        /// <param name="test">renvoie si la multiplications a été possible ou pas</param>
        public void MultiplicationsMatrice(int[,] matrice1, int[,] matrice2, out int[,] matriceMulti, out bool test)
        {
            matriceMulti = new int[matrice1.GetLength(0), matrice2.GetLength(1)];
            test = true;
            // vérification que le nombre de colonne de matrice1 est égal au nombre de ligne de matrice2
            if (matrice1.GetLength(1) == matrice2.GetLength(0))
            {
                for (int ligne = 0; ligne < matrice1.GetLength(0); ligne++)
                {
                    for (int colonne = 0; colonne < matrice2.GetLength(1); colonne++)
                    {
                        matriceMulti[ligne, colonne] = 0;
                        for (int i = 0; i < matrice1.GetLength(1); i++)
                        {
                            // multiplication de la matrice1 avec la matrice2 et solution dans la matriceMulti
                            matriceMulti[ligne, colonne] += matrice1[ligne, i] * matrice2[i, colonne];
                        }
                    }
                }
            }
            else
            {
                // renvoie que test est false c'est à dire que le nombre de colonne de matrice1 n'est pas égal au nombre de ligne de matrice2
                test = false;
            }
        }
    }
}
