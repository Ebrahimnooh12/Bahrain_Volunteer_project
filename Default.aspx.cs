using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bahrain_Volunteer
{
    public partial class _Default : Page
    {
      
        public string type="no";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["activeuser"] != null)
            {
                Active user = (Active)Session["activeuser"];
                type = user.type;
            }
            else
           if (Session["activeadmin"] != null)
            {
                Active user = (Active)Session["activeadmin"];
                type = user.type;
            }
            
            if(type.Trim() == "A")
            {
                GridView1.Visible = true;
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}