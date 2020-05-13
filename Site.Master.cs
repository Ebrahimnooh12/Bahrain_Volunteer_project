using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bahrain_Volunteer
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            Active user;
            username.Text= "";

            if (Session["activeuser"] != null)
            {
                user = (Active)Session["activeuser"];
                username.Text = user.username.ToString();
            }
            else
           if (Session["activeadmin"] != null)
            {
                user = (Active)Session["activeadmin"];
                username.Text = user.username.ToString();
            }

            

        }

        protected void logout(object sender, EventArgs e)
        {
            if(Session["activeuser"] != null)
            {
                Session.Remove("activeuser");
                username.Text = "";
            }
  
            if (Session["activeadmin"] != null)
            {
                Session.Remove("activeadmin");
                username.Text = "";
            }
        }
    }
}