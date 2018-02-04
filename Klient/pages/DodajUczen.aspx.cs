using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_DodajUczen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Service1Client sc = new Service1Client();
            foreach (var klasa in sc.WyswietlKlasy())
            {
                ListItem li = new ListItem();
                li.Value = klasa.Id.ToString();
                li.Text = klasa.Nazwa.ToString();
                ddlKlasa.Items.Add(li);
            }
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        Page.Validate("dodawanie");
        if (Page.IsValid)
        { 
            //int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            TUczen tu = new TUczen();
            tu.Imie = tbImie.Text;
            tu.Nazwisko = tbNazwisko.Text;
            tu.DataUrodzenia = DateTime.Parse(tbDataUrodzenia.Text);
            tu.Ulica = tbUlica.Text;
            tu.Kod = tbKod.Text;
            //tu.Id = id;
            tu.Miejscowosc = tbMiejscowosc.Text;
            tu.IdKlasy = int.Parse(ddlKlasa.SelectedValue.ToString());
            tu.Kontakt = tbTelefon.Text;
            sc.DodajUcznia(tu);
            sc.Close();
            Response.Redirect("~/pages/Uczen.aspx");
        }
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Uczen.aspx");
    }
}