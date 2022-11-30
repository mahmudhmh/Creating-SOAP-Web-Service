using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectMGMT
{
    /// <summary>
    /// Summary description for cToF
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class cToF : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public double FahrenheitToCeli(double Fahrenheit)
        {
            return ((Fahrenheit - 32) * 5) / 9;
        }
        [WebMethod]
        public double CeliToFahrenheit(double Celi)
        {
            return ((Celi * 9) / 5) + 32;
        }
    }
}
