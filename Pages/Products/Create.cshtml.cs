using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CihanAbay;
using CihanAbay.Models;

namespace CihanAbay.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly CihanAbay.DataBaseContext _context;

        public CreateModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          
            Product.CreatorId = Guid.Parse(HttpContext.Session.GetString("session"));
            Product.IsActive = true;
            Product.CreationTime = DateTime.UtcNow;
            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
