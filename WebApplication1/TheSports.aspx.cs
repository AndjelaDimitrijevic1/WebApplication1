using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TheSports : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                TextBox1.BorderColor = Color.Red;
                TextBox2.BorderColor = Color.Red;
            }
            else
            {
                using (con)
                {
                    con.Open();
                    string searchParameter = TextBox1.Text;
                    string searchParameter2 = TextBox1.Text;
                    SqlParameter p = new SqlParameter();
                    SqlParameter p2 = new SqlParameter();
                    p.Value = searchParameter;
                    p2.Value = searchParameter2;
                    p.ParameterName = "@searchParameter";
                    p2.ParameterName = "@searchParameter2";
                    string query = "INSERT INTO QuidditchAnualPass (FirstName,LastName) VALUES (@searchParameter,@searchParameter2)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p);
                    cmd.Parameters.Add(p2);
                    cmd.ExecuteNonQuery();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Text = "Gryffindor vs. Slytherin - October 22nd";
            Label5.Text = "Hufflepuff vs. Gryffindor - December 18th";
            Label6.Text = "Gryffindor vs. Ravenclaw - February 20th";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Text = "Gryffindor vs. Slytherin - October 22nd";
            Label5.Text = "Slytherin vs. Hufflepuff - November 19th";
            Label6.Text = "Slytherin vs. Ravenclaw - March 24th";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Text = "Gryffindor vs. Ravenclaw - February 20th";
            Label5.Text = "Slytherin vs. Ravenclaw - March 24th";
            Label6.Text = "Hufflepuff vs. Ravenclaw - April 7th";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Text = "Hufflepuff vs. Gryffindor - December 18th";
            Label5.Text = "Slytherin vs. Hufflepuff - November 19th";
            Label6.Text = "Hufflepuff vs. Ravenclaw - April 7th";
        }
    }
}