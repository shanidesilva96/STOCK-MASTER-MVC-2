using Microsoft.AspNetCore.Mvc;

namespace STOCK_MASTER_MVC.Controllers
{
    public class StockOutController : Controller
    {
        public IActionResult StockOut()
        {
            return View();
        }
    }
}
