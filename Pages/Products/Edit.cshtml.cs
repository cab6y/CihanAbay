using CihanAbay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CihanAbay.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly CihanAbay.DataBaseContext _context;

        public EditModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Product Product { get; set; } = default!;

        public IActionResult OnGet(Guid Id)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            Product = _context.Product.Where(x => x.id == Id).FirstOrDefault();
#pragma warning restore CS8601 // Possible null reference assignment.
            return Page();
        }




        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {

#pragma warning disable CS8604 // Possible null reference argument.
                Product.UpdaterId = Guid.Parse(HttpContext.Session.GetString("session"));
#pragma warning restore CS8604 // Possible null reference argument.
                Product.UpdateTime = DateTime.UtcNow;
                
                _context.Product.Update(Product);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}
