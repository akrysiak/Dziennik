using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_UsunUczen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var uczen in sc.wyswietlUczen(id))
            {
                lblUczen.Text = uczen.Imie + " " + uczen.Nazwisko;
            }
            sc.Close();
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Service1Client sc = new Service1Client();
        sc.UsunUcznia(id);
        sc.Close();
        Response.Redirect("~/pages/Uczen.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Uczen.aspx");
    }
}