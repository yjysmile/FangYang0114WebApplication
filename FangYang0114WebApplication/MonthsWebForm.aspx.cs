using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FangYang0114WebApplication
{
    public partial class MonthsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lstMonth.Items.Add("JAN");
            lstMonth.Items.Add("FEB");
            lstMonth.Items.Add("MAR");
            lstMonth.Items.Add("APR");
            lstMonth.Items.Add("MAY");
            lstMonth.Items.Add("JUN");
            lstMonth.Items.Add("JULY");
            lstMonth.Items.Add("AUG");
            lstMonth.Items.Add("OCT");
            lstMonth.Items.Add("NOV");
            lstMonth.Items.Add("DEC");
        }
    }
}