using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

struct Active
{
   public int id { get; set; }
   public string username { get; set; }
   public string type { get; set; }
} 
namespace Bahrain_Volunteer
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        protected void login_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = username.Text;
                string pass = MD5Hash(Password.Text);
                con.Open();
                
                string qry = "select * from users where username='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Note.Text = "";
                    if(sdr.GetString(3) == "A")
                    {
                        Session["activeadmin"] = new Active();
                        Active activeadmin = (Active)Session["activeadmin"];

                        activeadmin.id = sdr.GetInt32(0);
                        activeadmin.username = sdr.GetString(1);
                        activeadmin.type = sdr.GetString(3);

                        Session["activeadmin"] = activeadmin;

                        Response.Write(activeadmin.id +" "+activeadmin.username + " " + activeadmin.type);

                        Response.Redirect("Default.aspx");
                        con.Close();
                    }
                    else
                    {
                        Session["activeuser"] = new Active();
                        Active activeuser = (Active)Session["activeuser"];

                        activeuser.id = sdr.GetInt32(0);
                        activeuser.username = sdr.GetString(1);
                        activeuser.type = sdr.GetString(3);

                        Session["activeuser"] = activeuser;

                        Response.Write(activeuser.id + " " + activeuser.username + " " + activeuser.type);
                        
                        Response.Redirect("Default.aspx");
                        con.Close();
                    }
                }
                else
                {
                    Note.Text = "*Invalid Username/Password";

                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


    }
 }

