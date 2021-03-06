﻿using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_EdytujPrzedmiot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var wychowawca in sc.WyswietlNauczycieli())
            {
                ListItem li = new ListItem();
                li.Value = wychowawca.Id.ToString();
                li.Text = wychowawca.Nauczyciel.ToString();
                ddlNauczyciel.Items.Add(li);
            }
            foreach (var przedmiot in sc.wyswietlPrzedmiot(id))
            {
                tbPrzedmiot.Text = przedmiot.Nazwa;
                ddlNauczyciel.SelectedValue = przedmiot.IdNauczyciela.ToString();
            }
            sc.Close();
        }
    }

    protected void btnZapisz_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Service1Client sc = new Service1Client();
        TPrzedmiot pr = new TPrzedmiot();
        pr.Nazwa = tbPrzedmiot.Text;
        pr.IdNauczyciela = int.Parse(ddlNauczyciel.SelectedValue.ToString());
        pr.Id = id;
        sc.EdytujPrzedmiot(pr);
        sc.Close();
        Response.Redirect("~/pages/Przedmiot.aspx");
    }

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/pages/Przedmiot.aspx");
    }
}