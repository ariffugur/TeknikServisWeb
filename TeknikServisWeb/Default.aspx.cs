﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServisWeb.Entity;

namespace TeknikServisWeb
{
    public partial class Default : System.Web.UI.Page
    {
        dataEntities1 db = new dataEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLURUN.ToList();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t=new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}