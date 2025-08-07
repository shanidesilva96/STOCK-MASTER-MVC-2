using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_Master_DataAccess.Models;
using STOCK_MASTER_MVC.Models;
using Stock_Master_Service.Contracts;
using System.Diagnostics;

namespace STOCK_MASTER_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _IUnitOfWork = null;


        public HomeController(ILogger<HomeController> logger, IConfiguration config, IUnitOfWork IUnitOfWork)
        {
            _logger = logger;
            _IUnitOfWork = IUnitOfWork;
        }

        public IActionResult Index()
        {
            var bank = _IUnitOfWork.BankRepository.GetAll().ToList();

            var returnResult = new Models.Student();

            returnResult.BankList = bank.Select(b => new Models.Bank
            {
                BankId = b.BankId,
                BankName = b.BankName,
            }).ToList();

            return View(returnResult);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}