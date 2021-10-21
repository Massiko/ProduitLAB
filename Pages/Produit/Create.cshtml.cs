using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProduitLAB.Data;
using ProduitLAB.Models;

namespace ProduitLAB
{
    public class CreateModel : PageModel
    {
        private const string PageName = "./Produit_fichier";
        private readonly ProduitLAB.Data.ProduitLABContext _context;

        public CreateModel(ProduitLAB.Data.ProduitLABContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produit Produit { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produits.Add(Produit);
            await _context.SaveChangesAsync();

            return RedirectToPage(PageName);
        }
    }
}
