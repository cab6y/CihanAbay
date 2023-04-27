using CihanAbay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CihanAbay.Pages
{
    public class NewUserModel : PageModel
    {
        private readonly CihanAbay.DataBaseContext _context;

        public NewUserModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User user { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var count = _context.Users.Where(x=>x.Email == user.Email).FirstOrDefault();
                if(count == null)
                {
                    user.CreatorId = Guid.NewGuid();
                    user.IsActive = true;
                    user.CreationTime = DateTime.UtcNow;
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Login");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

    }
}
