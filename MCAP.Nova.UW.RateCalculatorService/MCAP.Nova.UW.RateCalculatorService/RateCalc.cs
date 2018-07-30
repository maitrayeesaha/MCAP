using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.Entity;
using MCAP.Nova.UW.RateCalculatorService.Models;

namespace MCAP.Nova.UW.RateCalculatorService
{
    public class RateCalc
    {
        /// <summary>
        /// Get the min rate for a product/program based on date range
        /// </summary>
        /// <param name="product"></param>
        /// <param name="program"></param>
        /// <param name="dtStartDate"></param>
        /// <param name="dtEndDate"></param>
        /// <returns></returns>
        public string Getrate(string product, string program, DateTime dtStartDate, DateTime dtEndDate)
        {
            Decimal rate = 0;
            try
            {
                MCAP_UWEntities db = new MCAP_UWEntities();
                rate = (from a in db.tblUWProdProgRates
                            where a.szProduct.Contains(product)
                            where a.szProgram.Contains(program)
                            where a.dtPeriodStartDate >= dtStartDate
                            where a.dtPeriodEndDate <= dtEndDate
                            select a.dblProductRate).Min();
            }
            catch 
            {
                rate = 0;
            }

            return rate.ToString();
        }
    }
}