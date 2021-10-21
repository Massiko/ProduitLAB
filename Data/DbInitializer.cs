using ProduitLAB.Data;
using ProduitLAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitLAB.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProduitLABContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Produits.Any())
            {
                return; // DB has been seeded
            }
            var Produits = new Produit[]
            {
                new Produit
                {
                    Identifiant="P_DECES",
                    LibelleCourt="Produit DECES",
                    LibelleLong="Produit DECES",
                    DateCreate=DateTime.Parse("1999-01-01"),
                    DateCom=DateTime.Parse("1999-01-01"),
                    Famille=Famille.Individuel,
                    SituationP=SituationP.Test
                }
                };
                foreach
                (Produit s in Produits)
            { 
                context.Produits.Add(s);
            }
            context.SaveChanges();
            var GarantiePs = new GarantieP[]
{
                new GarantieP
                {
                    GarantiePID=1050,
                    FamilleG= FamilleG.Garantie_Décés,
                    Libelle ="Garantie Décès",
                    Assureur=Models.Assureur.AXA,
                    Population = "All",
                    DateDeb = DateTime.Parse("1999-01-01"),
                    DateFin = DateTime.Parse("2030-01-01"),
                    EffetG = "Effet Garantie",
                    EffetCot="Effet Cottisation",
                    TypeAge ="Legal",
                    AgeTarif="",
                    Primaute="Capital",
                    AgeMin=16,
                    AgeMax=99,
                }
             };
            foreach
            (GarantieP o in GarantiePs)
            {
                context.GarantiePs.Add(o);
            }
            context.SaveChanges();
           
            var LienGPS = new LienGP[]
             {
                new LienGP { ProduitID=1,GarantiePID=1050,Assureur=Assureur.AXA}
             };
            foreach
            (LienGP k in LienGPS)
            {
                context.LienGPs.Add(k);
            }
            context.SaveChanges();
            var CotisationPS = new CotisationP[]
{
                new CotisationP
                {
                    CotisationPID=1050,
                    Paiement= Paiement.Cheque,
                    Payeur=Payeur.Souscripteur
                }
 };
            foreach
            (CotisationP m in CotisationPS)
            {
                context.CotisationPs.Add(m);
            }
            context.SaveChanges();
            var LienCPS = new LienCP[]
 {
                new LienCP { ProduitID=1,
                    CotisationPID=1050,
                    Paiement= Paiement.Cheque,
                    Payeur = Payeur.Souscripteur}
 };
            foreach
            (LienCP j in LienCPS)
            {
                context.LienCPs.Add(j);
            }
            context.SaveChanges();

        }
    }
}

