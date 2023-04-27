using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CihanAbay.Pages
{
    public class LogOutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                HttpContext.Session.Clear();
                return RedirectToPage("./Index");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
