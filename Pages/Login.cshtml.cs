using CihanAbay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CihanAbay.Pages
{
    public class LoginModel : PageModel
    {
        private readonly CihanAbay.DataBaseContext _context;
        [BindProperty]
        public User User { get; set; }

        public LoginModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var count = _context.Users.Where(x=> x.Email == User.Email && x.Password == User.Password).FirstOrDefault();
            if(count != null)
            {
                HttpContext.Session.SetString("session", count.id.ToString());
                HttpContext.Session.SetString("sessionUser", count.UserName);
            }

            return RedirectToPage("./Index");

        }
    }
}
