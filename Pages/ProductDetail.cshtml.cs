using CihanAbay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CihanAbay.Pages
{
    public class ProductDetailModel : PageModel
    {
        private readonly CihanAbay.DataBaseContext _context;
        [BindProperty]
        public Product product { get; set; }
        [BindProperty]
        public CihanAbay.Models.Basket Basket { get; set; } = default!;
        public ProductDetailModel(CihanAbay.DataBaseContext context)
        {
            _context = context;
        }
        public async void OnGet(Guid Id)
        {
            product = _context.Product.Where(x => x.id == Id).FirstOrDefault();
        }

        [HttpPost]

        public async Task<JsonResult> AddBasket(Guid productId)
        {


            try
            {
                var product = _context.Product.Where(x=>x.id == productId).FirstOrDefault();
                _ = Basket.ProductId == product.id;
                Basket.UserId = Guid.Parse(HttpContext.Session.GetString("session"));
                Basket.CreatorId = Guid.Parse(HttpContext.Session.GetString("session"));
                Basket.CreationTime = DateTime.Now;
                _context.Baskets.Add(Basket);
                _context.SaveChanges();
                return new JsonResult(true);
            

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

    }
}
