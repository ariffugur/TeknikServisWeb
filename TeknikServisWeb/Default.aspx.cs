using System;
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
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLURUN.ToList();
            Repeater2.DataBind();
        }
    }
}