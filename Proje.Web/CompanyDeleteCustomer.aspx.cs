using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyDeleteCustomer : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = db.Companies.Find(id);
            var a = p.Customer1.ToList();
            int id1 = Convert.ToInt32(a[0].Id);
            db.Customer.Remove(db.Customer.Find(id1));
            db.SaveChanges();
            Response.Redirect("CompanyCustomers.aspx");
        }
    }
}