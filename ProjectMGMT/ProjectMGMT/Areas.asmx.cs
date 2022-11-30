using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectMGMT
{
    /// <summary>
    /// Summary description for Areas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Areas : System.Web.Services.WebService
    {
        [WebMethod]
        public double AreaCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }
        [WebMethod]
        public int AreasQuare(int Length)
        {
            return (Length * Length);
        }
        [WebMethod]
        public int AreaRectangle(int Width,int Length)
        {
            return (Length * Width);
        }
        [WebMethod]
        public int AreaTriangle(int height,int baseOfTriangle)
        {
            return ((height * baseOfTriangle) / 2);
        }
    }
}
