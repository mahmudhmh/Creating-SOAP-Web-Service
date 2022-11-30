using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGMTWeb
{
    public partial class WebFormForMGMT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CircleBtn_Click(object sender, EventArgs e)
        {
            localhost.Areas wsAreas = new localhost.Areas();
            double rad = Convert.ToDouble(Circle.Text);
            CircleArea.Text = wsAreas.AreaCircle(rad).ToString();
        }
        protected void SquareBtn_Click(object sender, EventArgs e)
        {
            localhost.Areas wsAreas = new localhost.Areas();
            int len = Convert.ToInt16(Square.Text);
            SquareArea.Text = wsAreas.AreasQuare(len).ToString();
        }
        protected void RectangleBtn_Click(object sender, EventArgs e)
        {
            localhost.Areas wsAreas = new localhost.Areas();
            int len = Convert.ToInt16(Length.Text);
            int Wid = Convert.ToInt16(Width.Text);
            RectangleArea.Text = wsAreas.AreaRectangle(Wid, len).ToString();
        }
        protected void TriangleBtn_Click(object sender, EventArgs e)
        {
            localhost.Areas wsAreas = new localhost.Areas();
            int height = Convert.ToInt16(Height.Text);
            int ba = Convert.ToInt16(Base.Text);
            TriangleArea.Text = wsAreas.AreaTriangle(height,ba).ToString();
        }
    }
}