using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FangYang0114WebApplication
{
    public partial class Button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEx_Click(object sender, EventArgs e)
        {
            LabClick.Text =sender.GetType().Name;
        }

        protected void ButtonEx_Command(object sender, CommandEventArgs e)
        {
            LabClick.Text = e.CommandName;
        }

        protected void LinkButtonEx_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButtonEx_Command(object sender, CommandEventArgs e)
        {

        }

        protected void ImageButtonEx_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButtonEx_Command(object sender, CommandEventArgs e)
        {

        }
    }
}