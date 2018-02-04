using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_OcenyKlasa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int m_idn = -1;
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            
            Service1Client sc = new Service1Client();
            GridView1.DataSource = sc.wyswietlUczenKlasa(id);
            GridView1.DataBind();
            foreach(var klasa in sc.wyswietlKlase(id))
            {
                lblKlasa.Text = klasa.Nazwa;
                m_idn = klasa.Id_Wychowawcy;
            }
            foreach(var wychowawca in sc.wyswietlNauczyciela(m_idn))
            {
                lblWychowawca.Text = wychowawca.Nauczyciel;
            }
            sc.Close();
        }
    }
}