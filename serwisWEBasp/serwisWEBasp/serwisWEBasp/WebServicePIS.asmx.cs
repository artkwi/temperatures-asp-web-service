using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace serwisWEBasp
{
    /// <summary>
    /// Summary description for WebServicePIS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePIS : System.Web.Services.WebService
    {



        [WebMethod]
        public double CelsjuszToFahrenheit(double a)
        {
            double b;
            b = 32 + ((9.0 / 5.0) * a);
            return b;
        }

        [WebMethod]
        public double FahrenheitToCelsjusz(double a)
        {
            double b;
            b = (5.0/9.0)*(a-32);
            return b;
        }

        [WebMethod]
        public double KelwinToCelsjusz(double a)
        {
            double b;
            b = a-273.0;
            return b;
        }


        [WebMethod]
        public double CelsjuszToKelwin(double a)
        {
            double b;
            b = a+273;
            return b;
        }

        [WebMethod]
        public double FahrenheitToKelwin(double a)
        {
            double b;
            b = (a-32)*5/9+273;
            return b;
        }

        [WebMethod]
        public double KelwinToFahrenheit(double a)
        {
            double b;
            b = (9 / 5) * (a - 273) + 32;
            return b;
        }
        
      
    }
}
