using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujUczen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var klasa in sc.WyswietlKlasy())
            {
                ListItem li = new ListItem();
                li.Value = klasa.Id.ToString();
                li.Text = klasa.Nazwa.ToString();
                ddlKlasa.Items.Add(li);
            }
            foreach (var uczen in sc.wyswietlUczen(id))
            {
                tbImie.Text = uczen.Imie;
                tbNazwisko.Text = uczen.Nazwisko;
                tbDataUrodzenia.Text = uczen.DataUrodzenia.ToShortDateString();
                tbUlica.Text = uczen.Ulica;
                tbKod.Text = uczen.Kod;
                tbMiejscowosc.Text = uczen.Miejscowosc;
                tbTelefon.Text = uczen.Kontakt;
                ddlKlasa.SelectedValue = uczen.IdKlasy.ToString();
            }
            sc.Close();
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Service1Client sc = new Service1Client();
        TUczen tu = new TUczen();
        tu.Imie = tbImie.Text;
        tu.Nazwisko = tbNazwisko.Text;
        tu.DataUrodzenia = DateTime.Parse(tbDataUrodzenia.Text);
        tu.Ulica = tbUlica.Text;
        tu.Kod = tbKod.Text;
        tu.Miejscowosc = tbMiejscowosc.Text;
        tu.Kontakt = tbTelefon.Text;
        tu.IdKlasy = int.Parse(ddlKlasa.SelectedValue.ToString());
        tu.Id = id;
        sc.EdytujUcznia(tu);
        sc.Close();
        Response.Redirect("~/pages/Uczen.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Uczen.aspx");
    }
}