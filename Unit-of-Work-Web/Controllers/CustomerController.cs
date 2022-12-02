using Microsoft.AspNetCore.Mvc;
using Unit_of_Work_BusinessLayer.Abstract;
using Unit_of_Work_EntityLayer.Concrete;
using Unit_of_Work_Web.ViewModel;

namespace Unit_of_Work_Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult SendMoney()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMoney(SendMoneyVM sendMoneyVM)
        {
            return View();
        }
    }
}
