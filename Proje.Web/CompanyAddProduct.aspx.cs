using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;


namespace Proje.Web
{
    public partial class CompanyAddProduct : System.Web.UI.Page
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
            }
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product newproduct = new Product();
            newproduct.CompanyId = Convert.ToInt32(Session["compid"]);
            newproduct.ProductName = TxtName.Text;
            newproduct.CategoryId = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            newproduct.Stock = Convert.ToInt32(TxtStock.Text);
            newproduct.Price = decimal.Parse(TxtPrice.Text);
            newproduct.Code = Convert.ToInt32(TxtCode.Text);
            newproduct.CreateDate = DateTime.Now;
            newproduct.Active = true;
            db.Product.Add(newproduct);
            db.SaveChanges();
            Response.Redirect("CompanyProduct.aspx");
        }
    }
}