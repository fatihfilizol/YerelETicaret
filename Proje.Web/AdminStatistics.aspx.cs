using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminStatistics : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
             
            var ordr = (from x in db.Orders
                        where x.IsBasket==false
                        select new
                        {
                            x.Id
                        }).ToList();

            Label2.Text = ordr.Count.ToString();

            var deliveredordr = (from x in db.Orders
                        where x.Active==false && x.IsBasket==false
                        select new
                        {
                            x.Id
                        }).ToList();
            Label3.Text = deliveredordr.Count.ToString();
            var customer = (from x in db.Companies
                                 where x.Active == true
                                 select new
                                 {
                                     x.Id
                                 }).ToList();
            Label1.Text = customer.Count.ToString();
            var product = (from x in db.Product
                            where x.Active == true
                            select new
                            {
                                x.Id
                            }).ToList();
            Label4.Text = product.Count.ToString();
        }
    }
}