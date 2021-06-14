using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CustomerAddOrder : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        Orders order = new Orders();
        protected void Page_Load(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(Session["custid"]);
            var product = db.Product.ToList();
            //Müşteri Listesinde Bulunulan Firmaları listeleme
            if (Page.IsPostBack == false)
            {
                var sorgu = (from x in db.Customer
                             where x.Companies1.Id == c
                             select new
                             {
                                 x.CompanyId,
                                 x.Companies.CompanyName

                             }).ToList();

                DropDownList1.DataTextField = "CompanyName";
                DropDownList1.DataValueField = "CompanyId";
                DropDownList1.DataSource = sorgu;
                DropDownList1.DataBind();
            }

            // Seçilen Firmanın Ürünlerini Listeleme
            int a = Convert.ToInt32(DropDownList1.SelectedValue);
            var sorgu1 = (from x in db.Product
                          where x.CompanyId == a
                          select new
                          {
                              x.Id,
                              x.ProductName,
                              x.Price,
                              x.Stock,
                              x.Code,
                              x.Category.CategoryName


                          }).ToList();
            Repeater1.DataSource = sorgu1;
            Repeater1.DataBind();

            //Sepet
            var cart = (from x in db.Orders
                        where x.Customer.CustomerId == c && x.IsBasket==true
                        select new
                        {
                            x.Id,
                            x.ProductId,
                            x.Product.ProductName,
                            x.Product.Price,
                            x.Count,
                        }).ToList();


            Repeater2.DataSource = cart;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(Session["custid"]);
            var cart = (from x in db.Orders
                        where x.Customer.CustomerId == c && x.IsBasket == true
                        select new
                        {
                            x.Id
                        }).ToList();
            
            for (int i = 0; i < cart.Count; i++)
            {
                int id = cart[i].Id;
                var o = db.Orders.Find(id);
                o.IsBasket = false;
                o.Active = true;
                o.CreateDate = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}