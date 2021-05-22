using System;

namespace Gestion_Stock_Huile
{
    public class Huile : IHuile
    {
        private string nom;
        private int vf;
        private int vc;
        private double prix;
        private int stock;
        private string petrolier;

	    public Huile()
	    {
            nom = null;
            vf = 0;
            vc = 0;
            prix = 0.0;
            stock = 0;
            petrolier = null;
	    }

        public Huile(string nom, int vf, int vc, double prix, int stock, string petrolier)
	    {
            this.nom = nom;
            this.vf = vf;
            this.vc = vc;
            this.prix = prix;
            this.stock = stock;
            this.petrolier = petrolier;
	    }

        public string Nom { get => nom; set => nom = value; }

        public int Vf { get => vf; set => vf = value; }

        public int Vc { get => vc; set => vc = value; }

        public double Prix { get => prix; set => prix = value; }

        public int Stock { get => stock; set => stock = value; }

        public string Petrolier { get => petrolier; set => petrolier = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Nom: " + nom + " | VF: " + vf + " | VC: " + vc + " | Prix: " + prix + " | Stock: " + stock +
                " | Pétrolier: " + petrolier;
        }
    }
}