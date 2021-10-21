using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProduitLAB.Data;
using ProduitLAB.Models;

namespace ProduitLAB
{
    public class EditModel : PageModel
    {
        private readonly ProduitLAB.Data.ProduitLABContext _context;

        public EditModel(ProduitLAB.Data.ProduitLABContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produit Produit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produit = await _context.Produits.FirstOrDefaultAsync(m => m.ProduitID == id);

            if (Produit == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduitExists(Produit.ProduitID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProduitExists(int id)
        {
            return _context.Produits.Any(e => e.ProduitID == id);
        }
    }
}
