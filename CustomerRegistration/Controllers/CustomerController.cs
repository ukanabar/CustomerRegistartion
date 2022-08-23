using CustomerRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistration.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerContext _cct;

        public CustomerController(CustomerContext cct)
        {
            _cct = cct;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer cust)
        {
            _cct.Add(cust);
            _cct.SaveChanges();
            ViewBag.message = "The customer " + cust.UserName + " is saved successfully";
            return View();
        }
    }
}
