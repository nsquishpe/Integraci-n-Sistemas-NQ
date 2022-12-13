using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontRentaPeliculas
{
    public partial class RentaPelisFront : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Insert);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectDataSource3.Select();
        }
    }
}