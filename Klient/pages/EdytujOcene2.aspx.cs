using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujOcene2 : System.Web.UI.Page
{
    public static int iIDN, iIDU, iIDP, iIDK;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach(var ocena in sc.wyswietlOcene2(id))
            {
                ddlOcena.SelectedValue = ocena.Ocena.ToString().Trim();
                iIDK = ocena.IdKlasy;
                iIDN = ocena.IdNauczyciela;
                iIDP = ocena.IdPrzedmiot;
                iIDU = ocena.IdUcznia;
            }
            sc.Close();
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Service1Client sc = new Service1Client();
        TOcena ocena = new TOcena();
        ocena.Id = id;
        ocena.IdKlasy = iIDK;
        ocena.IdNauczyciela = iIDN;
        ocena.IdPrzedmiot = iIDP;
        ocena.IdUcznia = iIDU;
        ocena.Ocena = ddlOcena.SelectedValue;
        sc.EdytujOcene(ocena);
        sc.Close();
        Response.Redirect("~/pages/Oceny.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Oceny.aspx");
    }
}