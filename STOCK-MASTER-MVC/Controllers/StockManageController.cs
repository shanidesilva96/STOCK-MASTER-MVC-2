using Microsoft.AspNetCore.Mvc;

namespace STOCK_MASTER_MVC.Controllers
{
    public class StockManageController : Controller
    {
        public IActionResult StockManageIndex()
        {
            return View();
        }
    }
}
