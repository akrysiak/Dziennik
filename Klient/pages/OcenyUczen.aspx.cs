using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class pages_OcenyUczen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            GridView1.DataSource = sc.wyswietlPrzedOceny(id);
            GridView1.DataBind();
            
            foreach (var uczen in sc.wyswietlUczen(id))
            {
                lblUczen.Text = uczen.Imie + " " + uczen.Nazwisko;
            }
            sc.Close();
        }
    }
}