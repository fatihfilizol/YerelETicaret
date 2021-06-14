using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyAddCustomer : System.Web.UI.Page
    {
        Customer newcustomer = new Customer();
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Session["compid"]);
                var c = (from i in db.Companies where i.RankId != 1 && i.Active== true && i.Id != id select new { i.Id, i.CompanyName }).ToList();
                DropDownCustomer.DataTextField = "CompanyName";
                DropDownCustomer.DataValueField = "Id";
                DropDownCustomer.DataSource = c;
                DropDownCustomer.DataBind();

                
                var p = (from i in db.Companies where i.Id == id select new { i.PricePolicy1, i.PricePolicy2, i.PricePolicy3 }).ToList();
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy1.ToString(), "1"));
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy2.ToString(), "2"));
                RadioButtonList1.Items.Add(new ListItem(p[0].PricePolicy3.ToString(), "3"));

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int cid = Convert.ToInt32(DropDownCustomer.SelectedValue);
            var lst = db.Companies.Find(cid);
            newcustomer.CompanyId = Convert.ToInt32(Session["compid"]);
            newcustomer.CustomerId = Convert.ToInt32(DropDownCustomer.SelectedValue);
            newcustomer.PricePolicy= Decimal.Parse(RadioButtonList1.SelectedItem.Text);
            newcustomer.CreateDate = DateTime.Now;
            newcustomer.Active = true;
            if (lst.RankId==2)
            {
                lst.TwoUser = true;
                
            }
            db.Customer.Add(newcustomer);
            db.SaveChanges();
            Response.Redirect("CompanyCustomers.aspx");
            
        }
    }
}