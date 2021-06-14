using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminAddCompany : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var c = (from i in db.Rank where i.Id!=1 select new { i.Id, i.RankName }).ToList();
                DropDownList1.DataTextField = "RankName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = c;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Companies newcompany = new Companies();
            newcompany.CompanyName = TxtCompanyName.Text;
            newcompany.RankId = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            newcompany.Password = TxtPassword.Text;
            newcompany.Phone = TxtPhone.Text;
            newcompany.Address = TxtAddress.Text;
            newcompany.EMail = TxtMail.Text;
            newcompany.PricePolicy1 = decimal.Parse(TxtPricePolicy1.Text);
            newcompany.PricePolicy2 = decimal.Parse(TxtPricePolicy2.Text);
            newcompany.PricePolicy3 = decimal.Parse(TxtPricePolicy3.Text);
            newcompany.CreateDate = DateTime.Now;
            newcompany.Active = true;
            db.Companies.Add(newcompany);
            db.SaveChanges();
            Response.Redirect("AdminCompanies.aspx");

        }
    }
}