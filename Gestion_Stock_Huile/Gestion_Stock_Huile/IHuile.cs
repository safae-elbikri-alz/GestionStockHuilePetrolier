namespace Gestion_Stock_Huile
{ 
    public interface IHuile
    {
        string Nom { get; set; }
        string Petrolier { get; set; }
        double Prix { get; set; }
        int Stock { get; set; }
        int Vc { get; set; }
        int Vf { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}