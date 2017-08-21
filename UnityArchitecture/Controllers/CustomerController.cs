using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityArchitecture.BAL.Interfaces;
using UnityArchitecture.DomainModel.Models;

namespace UnityArchitecture.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: Customer
        public ActionResult Index()
        {
            Customer c = _customerService.GetCustomerById(1);

            return View();
        }
    }
}