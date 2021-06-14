﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyPendingOrdersToDeliveredOrders : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var n = db.Orders.Find(id);
            n.Active = false;
            db.SaveChanges();
            Response.Redirect("~/CompanyPendingOrders.aspx");
        }
    }
}