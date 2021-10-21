using System;
using System.Collections.Generic;

namespace ProduitLAB.Models
{
    public enum Famille { Individuel, Collectif }
    public enum SituationP { Test,Ouvert,Fermé }
    public class Produit
    {
        public int ProduitID { get; set; }
        public string Identifiant { get; set; }
        public string LibelleCourt { get; set; }
        public string LibelleLong { get; set; }
        public  Famille? Famille { get; set; }
        public  SituationP? SituationP { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateCom { get; set; }
        public ICollection<LienGP> LienGPs { get; set; }
        public ICollection<LienCP> LienCPs { get; set; }
    }
}



