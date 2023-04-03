using System;
using System.Collections.Generic;
using System.Text;

namespace Tom_Rijckaert_Code_Tris
{
    public struct MethodeDuProjet
    {

        Generation_Tableau(int nbLigne, int nbColonne, out int[,] tabAlea)
        {
            for (int ligne = 0; ligne < nbLigne-1; ligne++)
            {
                for (int colonne = 0; colonne < nbColonne-1; colonne++)
                {
                    tabAlea[ligne, colonne] = tabAlea.next(0, 20)
                }
            }


        }


    }
}
