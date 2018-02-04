using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Przedmiot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Service1Client sc = new Service1Client();
        GridView1.DataSource = sc.WyswietlPrzedmioty();
        GridView1.DataBind();
        sc.Close();
    }

    protected void btnDodaj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/DodajPrzedmiot.aspx");
    }
}