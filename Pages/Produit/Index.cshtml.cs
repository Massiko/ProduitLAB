using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProduitLAB.Data;
using ProduitLAB.Models;

namespace ProduitLAB
{
    public class IndexModel : PageModel
    {
        private readonly ProduitLAB.Data.ProduitLABContext _context;

        public IndexModel(ProduitLAB.Data.ProduitLABContext context)
        {
            _context = context;
        }

        public IList<Produit> Produit { get; set; }

        public async Task OnGetAsync()
        {
            Produit = await _context.Produits.ToListAsync();
        }
    }
}
