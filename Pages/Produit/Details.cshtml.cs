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
    public class DetailsModel : PageModel
    {
        private readonly ProduitLAB.Data.ProduitLABContext _context;

        public DetailsModel(ProduitLAB.Data.ProduitLABContext context)
        {
            _context = context;
        }

        public Produit Produit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Produit = await _context.Produits
                .Include(s => s.LienGPs)
                .ThenInclude(e => e.GarantieP)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ProduitID == id);
            if (Produit == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}


