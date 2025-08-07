// Ignore Spelling: Grn

using Microsoft.AspNetCore.Mvc;
using Stock_Master_Service.Contracts;

namespace STOCK_MASTER_MVC.Controllers
{
    public class GrnController : Controller
    {

        private readonly IUnitOfWork _IUnitOfWork = null;

        public GrnController(IConfiguration config, IUnitOfWork IUnitOfWork)
        {
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
    }
}
