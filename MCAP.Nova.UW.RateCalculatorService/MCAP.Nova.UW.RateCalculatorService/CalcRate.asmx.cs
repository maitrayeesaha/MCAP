using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MCAP.Nova.UW.RateCalculatorService
{
    /// <summary>
    /// Summary description for CalcRate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcRate : System.Web.Services.WebService
    {

        [WebMethod]
        public string Rate(string product, string program, DateTime startdate, DateTime enddate)
        {

            RateCalc prodrate = new RateCalc();
            string prdrt = prodrate.Getrate(product, program, startdate, enddate);

            return prdrt;
        }
    }
}
