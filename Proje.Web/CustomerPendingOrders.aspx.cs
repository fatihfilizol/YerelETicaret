using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CustomerPendingOrders : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Session["custid"]);
            var ordr = (from x in db.Orders
                        where x.Active == true && x.Customer.Companies1.Id == i
                        select new
                        {
                            x.Product.ProductName,
                            x.Count,
                            x.Customer.Companies.CompanyName,
                            x.Product.Companies.Address,
                            x.Product.Companies.Phone,
                            x.CreateDate,
                            x.SalePrice,



                        }).ToList();
            Repeater1.DataSource = ordr;
            Repeater1.DataBind();
        }
    }
}