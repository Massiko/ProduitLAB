using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitLAB.Models
{
    public enum Payeur { Souscripteur, Tiers }
    public enum TypePRD { Civil, Anniversaire }
    public enum Fraction { Sans, Mensuel, Trimestriel, Semestriel, Annuel }
    public enum TypeEcheance { Sans, Mensuel, Trimestriel, Semestriel, Annuel }
    public enum Paiement { Cheque,prélevement,Virement}
    public class CotisationP
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CotisationPID { get; set; }
        public TypePRD? TypePRD { get; set; }
        public TypeEcheance? TypeEcheance { get; set; }
        public Payeur? Payeur { get; set; }
        public Fraction? Fraction { get; set; }
        public Paiement? Paiement { get; set; }
        public ICollection<LienCP> LienCPs { get; set; }
        }
}


