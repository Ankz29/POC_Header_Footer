using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class CustomerModelController : Controller
    {
        // GET: CustomerModel
        public ActionResult Index()
        {
            List<CustomerModel> list = new List<CustomerModel>();
            list.Add(new CustomerModel(){ Name
                = "Ankita", Address = "Muddapur", Email_Id = "muddapurankita29@gmail.com", Phone_No = "0987654132", Gender = "female" });
            list.Add(new CustomerModel()
            {
                Name
                = "Anisha",
                Address = "Bhosale",
                Email_Id = "anishabhosale@gmail.com",
                Phone_No = "0987654132",
                Gender = "female"
            });
            list.Add(new CustomerModel()
            {
                Name
                = "Bahveshwari",
                Address = "Bhambar",
                Email_Id = "bahveshwaribhambar@gmail.com",
                Phone_No = "0987654132",
                Gender = "female"
            });
            list.Add(new CustomerModel()
            {
                Name
                = "Nikita",
                Address = "More",
                Email_Id = "nikitamore@gmail.com",
                Phone_No = "0987654132",
                Gender = "female"
            });

            return View("Index",list);
        }
    }
}