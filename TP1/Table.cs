using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Table
    {
        int x;
        int lenght;
        int donnees;

        //Constructeur
        public Table(int taille, int element)
        {
            this.lenght = taille;
            this.donnees = element;
        }
        //Insertion
        public void remplirtable(int element_ajouter, int new_position)
        {
            ajouterelement(element_ajouter, new_position);
        }
        public void ajouterelement(int element, int new_position)
        {
            int[] Tablea = new int[0];

            for (int i = 0; i < Tablea.Length; i++)
            {
                Tablea[i] = Tablea[Tablea.Length + 1];

            }
        }
        //Suppression
        public void supprimerelement(int taille)
        {
            int[] Tablea = new int[taille];
            for (int i = 0; i < Tablea.Length; i++)
            {
                Tablea[i] = Tablea[Tablea.Length - 1];
            }
        }

    }
}

