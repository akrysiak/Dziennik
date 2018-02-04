using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_DodajNauczyciela : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        Page.Validate("dodawanien");
        if (Page.IsValid)
        {
            Service1Client sc = new Service1Client();
            TNauczyciel tn = new TNauczyciel();
            tn.Nauczyciel = tbNauczyciel.Text;
            sc.DodajNauczyciela(tn);
            sc.Close();
            Response.Redirect("~/pages/Nauczyciel.aspx");
        }
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Nauczyciel.aspx");
    }
}