using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Huile
{
    class HuileMetier
    {
        private List<Huile> huiles;

        public HuileMetier()
        {
            huiles = new List<Huile>();
        }

        public void saisie(Huile huile)
        {
            huiles.Add(huile);
        }

        public List<Huile> liste()
        {
            return huiles;
        }

        public void trieStock()
        {
            huiles.OrderBy(o => o.Stock);
            //huiles.OrderBy(o => o.Stock).ToList();
        }

        public double valeurTotal(string fournisseur)
        {
            //Huile findByFournisseur = huiles.Find(h => h.Petrolier == fournisseur);
            //return findByFournisseur.Prix * findByFournisseur.Stock;
            double valeur = 0;
            foreach (var huile in huiles)
            {
                if(huile.Petrolier.Equals(fournisseur))
                {
                    valeur += huile.Prix * huile.Stock;
                }
            }
            return valeur;
        }

        public void reptureStock()
        {
            // T2
            // Je sais pas !
        }

        public List<Huile> deStockage()
        {
            // T3
            foreach (var huile in huiles)
            {
                if (huile.Stock <= 5)
                {
                    huile.Prix -= (40 * huile.Prix) / 100;
                }
            }
            return huiles;
        }

        public List<Huile> maxVC()
        {
            List<Huile> T4 = new List<Huile>();
            foreach (var huile in huiles)
            {
                if (huile.Vc == 50)
                {
                    T4.Add(huile);
                }
            }
            return T4;
        }

        public List<Huile> maxVF()
        {
            List<Huile> T5 = new List<Huile>();
            foreach (var huile in huiles)
            {
                if (huile.Vf == 20)
                {
                    T5.Add(huile);
                }
            }
            return T5;
        }

        public List<string> viscositeMax()
        {
            List<string> fournisseurs = new List<string>();
            foreach (var huile in huiles)
            {
                if (huile.Vc == 50 && huile.Vf == 20)
                {
                    fournisseurs.Add(huile.Petrolier);
                }
            }
            return fournisseurs;
        }

        public void spprimerViscosite(int vc, int vf)
        {
            foreach (var huile in huiles)
            {
                if (huile.Vc == vc && huile.Vf == vf)
                {
                    huiles.Remove(huile);
                }
            }
        }

        public void sauvegarder(List<Huile> liste)
        {
            foreach (var huile in liste)
            {
                //System.IO.File.WriteAllText(@"C:\Users\Soufiane\source\repos\Gestion_Stock_Huile\Gestion_Stock_Huile\fileDB\db.txt",
                System.IO.File.AppendAllText(@"C:\Users\Soufiane\source\repos\Gestion_Stock_Huile\Gestion_Stock_Huile\fileDB\db.txt",
                    huile.ToString() + Environment.NewLine);
            }
            
        }

        public void restaurer()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Soufiane\source\repos\Gestion_Stock_Huile\Gestion_Stock_Huile\fileDB\db.txt");

            foreach (string line in lines)
            {
            }
        }

    }
}
