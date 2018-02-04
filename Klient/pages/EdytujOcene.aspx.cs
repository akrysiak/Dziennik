using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujOcene : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString()); 
            int idu = int.Parse(Request.QueryString["idu"].ToString());
            Service1Client sc = new Service1Client();
            GridView1.DataSource = sc.wyswietlOcene(id,idu);
            GridView1.DataBind();
            foreach (var p in sc.wyswietlPrzedmiot(id))
            {
                lblPrzedmiot.Text = p.Nazwa;
            }
            sc.Close();
        }
    }
}