using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PieShop.Pages
{
    public class CheckoutCompleteModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thanks for your order. You'll soon enjoy our delicious pies!";
        }
    }
}
