using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatOutdoors.Mvc.Models;
using GreatOutdoors.Entities;
using Capgemini.GreatOutdoors.BusinessLayer;
using System.Threading.Tasks;
using static System.ValueTuple;

namespace GreatOutdoors.Mvc.Controllers
{
    public class RetailersController : Controller
    {
        // URL: Retailers/Create
        public async Task<ActionResult> Create()
        {
            //Creating and initailizing viewamodel object
            RetailerViewModel retailerViewModel = new RetailerViewModel()
            {

                // RetailerName = "Sarthak",
                // RetailerMobile = "7023511335",
                // ModifiedDateTime = DateTime.Now

            };
            //ceating object oftype RetailerBL
            RetailerBL retailerBL = new RetailerBL();

            //List of retailers from RetailerBL
            List<Retailer> retailers = await retailerBL.GetAllRetailersBL();
            //


            //calling view 
            return View(retailerViewModel);
        }

        // URL: Retailers/Create
        [HttpPost]
        public async Task<ActionResult> Create(RetailerViewModel retailerVM)
        {
            //create object of personBL

            RetailerBL retailerBL = new RetailerBL();

            //create object of retailer Entity Model
            Retailer retailer = new Retailer();

            //storing fields in retailer(Entity)  object form retailerVM object
            retailer.RetailerName = retailerVM.RetailerName;
            retailer.RetailerMobile = retailerVM.RetailerMobile;
            retailer.Email = retailerVM.Email;
            // retailer.Gender = retailerVM.Gender;
            retailer.RetailerPassword = retailerVM.RetailerPassword;


            //call the AddretailerBL method to add retailer
            (bool IsAdded, Guid RetailerID) = await retailerBL.AddRetailerBL(retailer);
            if (IsAdded)
            {
                return Content("This route will register the retailer");
            }
            else
            {
                return Content("Retailer not registered");
            }
        }
    }
}