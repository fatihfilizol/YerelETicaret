using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyCustomers : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["compid"]);
            var cust = (from x in db.Customer
                        where x.Active == true && x.CompanyId == id
                        select new
                        {
                            x.Companies1.Id,
                            x.Companies1.CompanyName,
                            x.Companies1.Address,
                            x.Companies1.Phone,
                            x.Companies1.EMail,
                            x.PricePolicy

                        }).ToList();

            Repeater1.DataSource = cust;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var search = TxtCompanies.Text;
            int id = Convert.ToInt32(Session["compid"]);
            var cust = (from x in db.Customer
                        where x.Active == true && x.CompanyId == id && x.Companies1.CompanyName == search
                        select new
                        {
                            x.Companies1.Id,
                            x.Companies1.CompanyName,
                            x.Companies1.Address,
                            x.Companies1.Phone,
                            x.Companies1.EMail,
                            x.PricePolicy

                        }).ToList();

            Repeater1.DataSource = cust;
            Repeater1.DataBind();
        }
    }
}