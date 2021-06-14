using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminPendingOrders : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var ordr = (from x in db.Orders
                        where x.Active == true
                        select new
                        {
                            x.Product.ProductName,
                            x.Count,
                            x.Customer.CustomerId,
                            x.Customer.Companies.Address,
                            x.Customer.Companies.Phone,
                            x.CreateDate,
                            x.SalePrice,
                            x.Customer.CompanyId,



                        }).ToList();

            Repeater1.DataSource = ordr;
            Repeater1.DataBind();
        }
    }
}