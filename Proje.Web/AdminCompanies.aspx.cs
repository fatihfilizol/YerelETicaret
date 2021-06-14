using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminCompanies : System.Web.UI.Page
    {
        YerelETicaretDBEntities db = new YerelETicaretDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var comp = (from x in db.Companies
                        where x.Active == true
                        select new
                        {
                            x.CompanyName,
                            x.Address,
                            x.EMail,
                            x.Phone,
                            x.PricePolicy1,
                            x.PricePolicy2,
                            x.PricePolicy3,
                            x.Rank.RankName,
                            x.Id


                        }).ToList();

            Repeater1.DataSource = comp;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var search = TxtCompanies.Text;
            var comp = (from x in db.Companies
                        where x.Active == true && x.CompanyName == search
                        select new
                        {
                            x.CompanyName,
                            x.Address,
                            x.EMail,
                            x.Phone,
                            x.PricePolicy1,
                            x.PricePolicy2,
                            x.PricePolicy3,
                            x.Rank.RankName,
                            x.Id


                        }).ToList();

            Repeater1.DataSource = comp;
            Repeater1.DataBind();
        }

        
    }
}