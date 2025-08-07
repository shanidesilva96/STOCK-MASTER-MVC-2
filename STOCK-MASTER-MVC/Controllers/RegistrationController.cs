using Microsoft.AspNetCore.Mvc;
using Stock_Master_DataAccess.Models;
using STOCK_MASTER_MVC.Models;
using Stock_Master_Service.Contracts;

namespace STOCK_MASTER_MVC.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger< RegistrationController> _logger;
        private readonly IUnitOfWork _IUnitOfWork = null;


        public  RegistrationController(ILogger< RegistrationController> logger, IUnitOfWork IUnitOfWork)
        {
            _logger = logger;
            _IUnitOfWork = IUnitOfWork;
        }
        #region --------------------------User
        public IActionResult User()
        {
            var userResult = _IUnitOfWork.SM_USER_Repository.GetAll().ToList();
            var userResult2 = _IUnitOfWork.SM_USER_Repository.GetAll().Where(w=> w.NIC == "958765523V").ToList();

            var users = userResult.Select(smUser => new UserList
            {
                User_ID = smUser.User_ID,
                First_Name = smUser.First_Name,
                Middle_Name = smUser.Middle_Name,
                Last_Name = smUser.Last_Name,
                Prefix_ID = smUser.Prefix_ID,
                User_Type_ID = smUser.User_Type_ID,
                Email = smUser.Email,
                Username = smUser.Username,
                Password = smUser.Password,
                NIC = smUser.NIC,
                Mobile_Number = smUser.Mobile_Number,
                User_Display_Number = smUser.User_Display_Number,
                User_Display_Name = smUser.User_Display_Name
            }).ToList();

            var user = new USER();
            user.UserList = users;

            return View(user);
        }
        public IActionResult AddNewUser()
        {
            return View();
        }
        #endregion

        #region --------------------------Supplier
        public IActionResult Supplier()
        {
            return View();
        }
        public IActionResult AddNewSupplier()
        {
            return View();
        }
        #endregion

        #region -------------------------- Patient
        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult AddNewPatient()
        {
            return View();
        }
        #endregion

        #region --------------------------Item
        public IActionResult Item()
        {
            return View();
        }
        public IActionResult AddNewItem()
        {
            return View();
        }
        #endregion
    }
}
