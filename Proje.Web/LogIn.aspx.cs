using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;


namespace Proje.Web
{
    public partial class LogIn : System.Web.UI.Page
    {
        Companies com = new Companies();
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = (from x in db.Companies
                         where x.EMail == TxtMail.Text && x.Password == TxtPassword.Text && x.Active == true
                         select new
                         {
                             x.Id,
                             x.RankId

                         }).ToList();
            if (sorgu.Any())
            {
                if (sorgu[0].RankId == 1)
                {
                    Response.Redirect("AdminPendingOrders.aspx");
                }
                else if (sorgu[0].RankId == 2)
                {
                    Session.Add("compid", Convert.ToInt32(sorgu[0].Id));
                    Response.Redirect("CompanyPendingOrders.aspx");
                }
                else if (sorgu[0].RankId == 3)
                {
                    Session.Add("custid", Convert.ToInt32(sorgu[0].Id));
                    Response.Redirect("CustomerPendingOrders.aspx");
                }
                else
                {
                    Response.Write("Hatalı Giriş Yaptınız");
                }
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız");
            }
        }
    }
}