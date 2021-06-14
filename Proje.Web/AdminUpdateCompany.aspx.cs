using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminUpdateCompany : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var r = (from i in db.Rank where i.Id != 1 select new { i.Id, i.RankName }).ToList();
                DropDownList1.DataTextField = "RankName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = r;
                DropDownList1.DataBind();

                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var p = db.Companies.Find(id);
                TxtCompanyName.Text = p.CompanyName;
                TxtAddress.Text = p.Address;
                TxtPhone.Text = p.Phone;
                TxtMail.Text = p.EMail;
                TxtPricePolicy1.Text = p.PricePolicy1.ToString();
                TxtPricePolicy2.Text = p.PricePolicy2.ToString();
                TxtPricePolicy3.Text = p.PricePolicy3.ToString();
                DropDownList1.SelectedValue = p.RankId.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = db.Companies.Find(id);
            p.CompanyName = TxtCompanyName.Text;
            p.Password = TxtPassword.Text;
            p.Address = TxtAddress.Text;
            p.EMail = TxtMail.Text;
            p.Phone = TxtPhone.Text;
            p.PricePolicy1 = decimal.Parse(TxtPricePolicy1.Text);
            p.PricePolicy2 = decimal.Parse(TxtPricePolicy2.Text);
            p.PricePolicy3 = decimal.Parse(TxtPricePolicy3.Text);
            p.RankId = Convert.ToInt32(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("AdminCompanies.aspx");
        }
    }
}