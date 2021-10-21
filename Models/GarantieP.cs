using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitLAB.Models
{
    public enum FamilleG { Garantie_capital_différé,Garantie_Décés}//Famille de Garanties
    public enum TypeG { Déces, Incapacité,Invalidté,Rente}//Type de Grantie
    public enum Assureur { AXA,Groupama,Predica}//Type de Assureur
    public class GarantieP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int GarantiePID { get; set; }
        public FamilleG ? FamilleG{ get; set; }
        public TypeG? TypeG { get; set; }
        public string Libelle { get; set; }
        public string Population { get; set; }
        public Assureur? Assureur { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public string EffetG { get; set; }
        public string EffetCot { get; set; }
        public string TypeAge { get; set; }
        public string AgeTarif { get; set; }
        public string Primaute { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public ICollection<LienGP> lienGPs { get; set; }
    }
}

