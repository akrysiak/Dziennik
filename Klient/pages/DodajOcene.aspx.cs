using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_DodajOcene : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Service1Client sc = new Service1Client();
        foreach(var n in sc.WyswietlNauczycieli())
        {
            ListItem li = new ListItem();
            li.Value = n.Id.ToString();
            li.Text = n.Nauczyciel;
            ddlNauczyciel.Items.Add(li);
        }
        foreach (var p in sc.WyswietlPrzedmioty())
        {
            ListItem li = new ListItem();
            li.Value = p.Id.ToString();
            li.Text = p.Nazwa;
            ddlPrzedmiot.Items.Add(li);
        }
        sc.Close();
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        int idk = int.Parse(Request.QueryString["idk"].ToString());
        Service1Client sc = new Service1Client();
        TOcena to = new TOcena();
        to.IdKlasy = idk;
        to.IdNauczyciela = int.Parse(ddlNauczyciel.SelectedValue);
        to.IdPrzedmiot = int.Parse(ddlPrzedmiot.SelectedValue);
        to.IdUcznia = id;
        to.Ocena = ddlOcena.SelectedValue;
        sc.DodajOcene(to);
        Response.Redirect("~/pages/Oceny.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Oceny.aspx");
    }
}