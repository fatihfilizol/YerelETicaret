using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CustomerAddCart : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        Orders order = new Orders();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(Session["custid"]);
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = db.Product.Find(id);
            int companyid = p.CompanyId;
            var c = (from i in db.Customer where i.CustomerId == id1 && i.CompanyId == companyid select new { i.Id, i.PricePolicy }).ToList();
            order.ProductId = p.Id;
            order.CustomerId = c[0].Id; 
            order.Count = 1;
            order.CreateDate = DateTime.Now;
            order.Active = false;
            order.SalePrice = p.Price - (p.Price * c[0].PricePolicy);
            order.IsBasket = true;
            order.StatusId = 1;
            db.Orders.Add(order);
            db.SaveChanges();
            Response.Redirect("~/CustomerAddOrder.aspx");
        }
    }
}