using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["codigo"];
            Datos d = new Datos();
            d.Codigo = Convert.ToInt32(Label1.Text);
            d.buscar();
            Label2.Text = d.Nombre;
        }
    }
}