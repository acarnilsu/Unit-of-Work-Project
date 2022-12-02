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
            var sender = _customerService.TGetByID(sendMoneyVM.SenderID);
            var receiver = _customerService.TGetByID(sendMoneyVM.ReceiverID);

            if (sender.Balance > sendMoneyVM.Amount)
            {
                sender.Balance -= sendMoneyVM.Amount;
                receiver.Balance += sendMoneyVM.Amount;

                var Process = new List<Customer>()
            {
                sender, receiver
            };

                _customerService.TUpdateRange(Process);
            }
            else
            {
                ViewBag.status = "Para yok fakir";
            }

            return View();
        }
    }
}
