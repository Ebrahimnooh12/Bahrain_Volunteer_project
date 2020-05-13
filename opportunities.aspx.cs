using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bahrain_Volunteer
{
    public partial class opportunities : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string [] mss = new string[10];
            string Newpass = "";
            int number;

            Boolean empty = false;
            Boolean Isnumber = true;
            Boolean pass = false;

            //Text
            if(email.Text.IsNullOrWhiteSpace()) { mss[0] = "Email Is required";empty = true;}
            if(firstname.Text.IsNullOrWhiteSpace()) { mss[1] = "First Name Is required";empty = true; }
            if(lastname.Text.IsNullOrWhiteSpace()) { mss[2] = "Last Name Is required";empty = true; }
            if (specialty.Text.IsNullOrWhiteSpace()) { mss[3] = "Specialty Is required"; empty = true; }
            if (education.Text.IsNullOrWhiteSpace()) { mss [4]= "Education Is required"; empty = true; }
            
            //Numbers  CPR
            if(cpr.Text.IsNullOrWhiteSpace() ) 
                { 
                    mss[5] = "CPR Is required";
                    empty = true; 
                }

            if(!Int32.TryParse(cpr.Text, out number))
            {
                mss[6] = "CPR must be a number";
                Isnumber = false;
            }

            //Number TEL
                if (tel.Text.IsNullOrWhiteSpace() ) 
                { 
                    mss[7] = "TEL Is required";
                    empty = true; 
                    
                }

                if (!Int32.TryParse(tel.Text, out number))
                {
                    mss[8] = "CPR must be a number";
                    Isnumber = false;
                }


            //Password 
            if (tel.Text.IsNullOrWhiteSpace() ) 
                {
                    mss [9]= "TEL Is required";
                    empty = true;
            }
            if(Password.Text == cpassword.Text)
            {
                pass = true;
                Newpass = MD5Hash(Password.Text);
            }
            else
            {
                mss[10] = "Comfirm Password Not Matched";
            }



            if(!empty || Isnumber || !pass)
            {
                register(Newpass);
            }

            else
            {
                mess.Attributes.Add("class", "show");
                string text = "";

                for (int i = 0; i<mss.Length; i++)
                {
                    text += "<p>* " +mss[i]+"</p></br>";
                }
                mess.InnerHtml = text;
            }
            

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

        private void register(string p)
        {
            con.Open();

            SqlCommand command = new SqlCommand("insert into users (username,password,type) values(@username,@password,@type)", con);
            command.Parameters.AddWithValue("username", email.Text);
            command.Parameters.AddWithValue("password", p);
            command.Parameters.AddWithValue("type", 'T');
            command.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("insert into volunteer (username,fname,lname,cpr,specialty,education,phone) values(@username,@fname,@lname,@cpr,@specialty,@education,@phone)", con);
            command1.Parameters.AddWithValue("fname", firstname.Text);
            command1.Parameters.AddWithValue("lname", lastname.Text);
            command1.Parameters.AddWithValue("cpr", cpr.Text);
            command1.Parameters.AddWithValue("specialty", specialty.Text);
            command1.Parameters.AddWithValue("education", education.Text);
            command1.Parameters.AddWithValue("phone", tel.Text);
            command1.Parameters.AddWithValue("username", email.Text);
            command1.ExecuteNonQuery();

            Response.Redirect("thanks.aspx");


            con.Close();
        }
    }
}