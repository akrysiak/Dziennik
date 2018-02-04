using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujOceny : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var p in sc.WyswietlPrzedmioty())
            {
                ListItem li = new ListItem();
                li.Value = p.Id.ToString();
                li.Text = p.Nazwa;
                ddlPrzedmiot.Items.Add(li);
            }
            sc.Close();
        }
    }

    protected void btnZatw_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        string sUrl = string.Format("~/pages/EdytujOcene.aspx?id={0}&idu={1}", ddlPrzedmiot.SelectedValue, id);
        Response.Redirect(sUrl);
    }
}