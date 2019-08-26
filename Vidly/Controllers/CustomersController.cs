using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Customers/
        public ActionResult Index()
        {
            var cust = GetCustomers();
            return View(cust);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "Gaurav Tripathi"},
                new Customer{Id = 2, Name = "Ayush Laad"},
                new Customer{Id = 3, Name = "Shivam Sisodiya"}
            };
        }
	}
}