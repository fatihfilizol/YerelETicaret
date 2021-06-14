using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CustomerToCompany : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["custid"]);
            var cus = db.Companies.Find(id);
            if (cus.TwoUser == true)
            {
                Session.Add("compid", id);
                Response.Redirect("CompanyPendingOrders.aspx");
            }
            else
            {
                Response.Redirect("CustomerPendingOrders.aspx");
            }
        }
    }
}