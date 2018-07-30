using MCAP.Nova.UW.GetMinimumRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCAP.Nova.UW.GetMinimumRate.Controllers
{
    public class HomeController : Controller
    {
        MCAP_UWEntities db = new MCAP_UWEntities();
        public ActionResult Index()
        {
            ViewBag.Products = new SelectList(db.tblDropDownLists.Where(x => x.szCode == "Product"), "szValue", "szValue");
            ViewBag.Programs = new SelectList(db.tblDropDownLists.Where(x => x.szCode == "Program"), "szValue", "szValue");
            return View();
        }
        [HttpPost]
        public ActionResult Index(string product, string program, tblDropDownList list)
        {
            try
            {
                CalcRateServiceReference1.CalcRateSoapClient client = new CalcRateServiceReference1.CalcRateSoapClient();
   
                    product = Request.Form["Products"];
                    program = Request.Form["Programs"];
                    DateTime startdate = list.startdate;
                    DateTime enddate = list.enddate;
                    ViewBag.Products = new SelectList(db.tblDropDownLists.Where(x => x.szCode == "Product"), "szValue", "szValue");
                    ViewBag.Programs = new SelectList(db.tblDropDownLists.Where(x => x.szCode == "Program"), "szValue", "szValue");
                if (!string.IsNullOrEmpty(product) && (!string.IsNullOrEmpty(program)))
                {
                    string minrate = client.Rate(product, program, startdate, enddate);
                    ViewData["minimum"] = minrate;
                }
                else
                { 
                    ViewData["minimum"] = "Invalid Selection (Please Select Product and Program)";
                }
                   
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            
            }

            return View();
        }


    }
}