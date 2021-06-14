using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyStatistics : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["compid"]);
            var ordr = (from x in db.Orders
                        where x.Customer.CompanyId == id
                        select new
                        {
                            x.Id
                        }).ToList();

            Label1.Text = ordr.Count.ToString();

            var deliveredordr = (from x in db.Orders
                        where x.Customer.CompanyId == id && x.Active==false
                        select new
                        {
                            x.Id
                        }).ToList();
            Label2.Text = deliveredordr.Count.ToString();
            var customer = (from x in db.Customer
                                 where x.CompanyId == id && x.Active == true
                                 select new
                                 {
                                     x.Id
                                 }).ToList();
            Label3.Text = customer.Count.ToString();
            var product = (from x in db.Product
                            where x.CompanyId == id && x.Active == true
                            select new
                            {
                                x.Id
                            }).ToList();
            Label4.Text = product.Count.ToString();
        }
    }
}