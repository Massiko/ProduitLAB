using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitLAB.Models
{
    public class LienGP
    {
        public int LienGPID { get; set; }
        public int GarantiePID { get; set; }
        public int ProduitID { get; set; }
        public Produit Produit { get; set; }
        public GarantieP GarantieP { get; set; }
        public Assureur Assureur { get; internal set; }
    }
}

