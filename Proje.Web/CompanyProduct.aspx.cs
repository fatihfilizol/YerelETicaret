using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class CompanyProduct : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["compid"]);
            var prdct = (from x in db.Product
                         where x.Active == true && x.CategoryId == id
                         select new
                         {
                             x.Id,
                             x.ProductName,
                             x.Category.CategoryName,
                             x.Stock,
                             x.Price,
                             x.Code
                             

                         }).ToList();

            Repeater1.DataSource = prdct;
            Repeater1.DataBind();
        }
    }
}