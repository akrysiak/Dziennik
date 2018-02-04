using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_DodajKlase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            Service1Client sc = new Service1Client();
            foreach (var wychowawca in sc.WyswietlNauczycieli())
            {
                ListItem li = new ListItem();
                li.Value = wychowawca.Id.ToString();
                li.Text = wychowawca.Nauczyciel.ToString();
                ddlWychowawca.Items.Add(li);
            }
        }
        }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Klasa.aspx");
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        Page.Validate("dodawaniek");
        if (Page.IsValid)
        {
            //int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            TKlasa tk = new TKlasa();
            tk.Nazwa = tbNazwa.Text;
            tk.Id_Wychowawcy = int.Parse(ddlWychowawca.SelectedValue.ToString());
            sc.DodajKlase(tk);
            sc.Close();
            Response.Redirect("~/pages/Klasa.aspx");
        }
    }
}