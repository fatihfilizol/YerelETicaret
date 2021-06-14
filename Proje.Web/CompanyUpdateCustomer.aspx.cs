using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyUpdateCustomer : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var comp = db.Companies.Find(id);
                int id2 = comp.Id;
                var c = (from i in db.Companies where i.Id == id2 select new { i.Id, i.CompanyName }).ToList();
                DropDownCustomer.DataTextField = "CompanyName";
                DropDownCustomer.DataValueField = "Id";
                DropDownCustomer.DataSource = c;
                DropDownCustomer.DataBind();


                int id1 = Convert.ToInt32(Session["compid"]);
                var p = (from i in db.Companies where i.Id == id1 select new { i.PricePolicy1,i.PricePolicy2,i.PricePolicy3 }).ToList();
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy1.ToString(), "1"));
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy2.ToString(), "2"));
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy3.ToString(), "3"));

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = db.Companies.Find(id);
            var a = p.Customer1.ToList();
            a[0].PricePolicy = Decimal.Parse(RadioButtonList1.SelectedItem.Text);
            db.SaveChanges();
            Response.Redirect("CompanyCustomers.aspx");
        }
    }
}