namespace ProduitLAB.Models
{
    public class LienCP
    {
        public int LienCPID { get; set; }
        public int CotisationPID { get; set; }
        public int ProduitID { get; set; }
        public Produit Produit { get; set; }
        public CotisationP CotisationP { get; set; }
        public Paiement Paiement { get; internal set; }
        public Payeur Payeur { get; internal set; }
    }
}
