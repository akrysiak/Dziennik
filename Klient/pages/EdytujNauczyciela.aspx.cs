using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujNauczyciela : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
           
            foreach (var nauczyciel in sc.wyswietlNauczyciela(id))
            {
                tbNauczyciel.Text = nauczyciel.Nauczyciel;
            }
            sc.Close();
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Service1Client sc = new Service1Client();
        TNauczyciel tn = new TNauczyciel();
        tn.Nauczyciel = tbNauczyciel.Text;
        tn.Id = id;
        sc.EdytujNauczyciela(tn);
        sc.Close();
        Response.Redirect("~/pages/Nauczyciel.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Nauczyciel.aspx");
    }
}