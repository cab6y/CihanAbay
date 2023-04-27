using CihanAbay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CihanAbay.Pages.Basket
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CihanAbay.DataBaseContext _context;
        public Guid CurrentUser { get; set; }

        public IndexModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }

        public IList<CihanAbay.Models.Basket> Basket { get; set; } = default!;
        public async Task OnGetAsync()
        {
            CurrentUser = Guid.Parse(HttpContext.Session.GetString("session"));
            if (_context.Product != null)
            {
                Basket = await _context.Baskets.Where(x=>x.UserId == CurrentUser).ToListAsync();
            }
        }
    }
}
