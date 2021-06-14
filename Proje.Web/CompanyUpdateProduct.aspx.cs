using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyUpdateProduct : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var c = (from i in db.Category select new { i.Id, i.CategoryName }).ToList();
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = c;
                DropDownList1.DataBind();


                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var p = db.Product.Find(id);
                TxtName.Text = p.ProductName;
                TxtCode.Text = p.Code.ToString();
                TxtStock.Text = p.Stock.ToString();
                TxtPrice.Text = p.Price.ToString();
                DropDownList1.SelectedValue = p.CategoryId.ToString();
            }
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = db.Product.Find(id);
            p.ProductName = TxtName.Text;
            p.Code =Convert.ToInt32(TxtCode.Text);
            p.Stock = Convert.ToInt32(TxtStock.Text);
            p.Price = decimal.Parse(TxtPrice.Text);
            p.CategoryId = Convert.ToInt32(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("CompanyProduct.aspx");
        }
    }
}