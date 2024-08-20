using Microsoft.AspNetCore.Mvc;
using NetTeamMVC.Models;
using System.Reflection;

namespace NetTeamMVC.Controllers
{
    public class CustomerController : Controller
    {
        public static List<CustomerModel> Customers = new List<CustomerModel>()
        {
        new CustomerModel()
        {
                Id=1,
                Name = "Israel Perez Trejo",
                Address="Av Siempre Viva 123",

        },

        new CustomerModel
        {
            Id = 2,
            Name = "Emanuel Durán",
            Address = "Venezuela"

        },


        new CustomerModel
        {
            Id = 3,
            Name = "Claudia Durán",
            Address = "Venezuela, Ve"

        },
     };

       public CustomerController()
        {
            //Customers.Add(new CustomerModel
            //{
            //    Id = 123,
            //    Name = "Israel Perez ",
            //    Address = "Av Siempre Viva 123",

            //});

            //Customers.Add(new CustomerModel
            //{
            //    Id = 234,
            //    Name = "Emanuel Durán",
            //    Address = "Venzuela",

            //});

            //Customers.Add(new CustomerModel
            //{
            //    Id = 345,
            //    Name = "Claudia Duran",
            //    Address = "Caracas, Ve",

            //});
        }


      

        public IActionResult Index()
        {
            return View(Customers);
        }

        public IActionResult Creation()
        {
            return View(new NetTeamMVC.Models.CustomerModel
            {
                Name= "Isra Pérez",
                Address= "Ecatepec, México",


            });
        }

        public IActionResult Save(CustomerModel customer)
        {
            Customers.Add(customer);
            return View("Index");
        }
    }




    //public IActionResult Details()
    //{
    //    CustomerModel model = new CustomerModel
    //    {
    //        Id = 1,
    //        Name = "Israel Pérez Trejo",
    //        Address= "Ecatepec de Morelos, México"

    //    };
    //    return View(model);
    //}
}
