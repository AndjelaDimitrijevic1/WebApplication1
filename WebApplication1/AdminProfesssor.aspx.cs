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
    public partial class AdminProfesssor : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Admin1" && TextBox2.Text == "Password1")
            {
                TextBox1.Text = null;
                TextBox1.BorderColor = Color.Black;
                TextBox2.BorderColor = Color.Black;
                HeaderLabel.Visible = true;
                Label4.Visible = true;
                TextBox3.Visible = true;
                Label5.Visible = true;
                TextBox4.Visible = true;
                Button2.Visible = true;
                using (con)
                {
                    con.Open();
                    string query = "SELECT p.FirstName, p.LastName, s.SubjectName  FROM Professors p, Subjects s  WHERE p.SubjectID=s.SubjectID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    reader.Close();
                }
            }
            else
            {
                MessageLabel.Text = "Invalid username or password!";//of course it won't tell you which one! why would it!
                TextBox1.Text = null;
                TextBox1.BorderColor = Color.Red;
                TextBox2.BorderColor = Color.Red;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    string searchParameter = TextBox3.Text.Trim();
                    string searchParameter2 = TextBox4.Text.Trim();
                    SqlParameter p = new SqlParameter();
                    SqlParameter p2 = new SqlParameter();
                    p.Value = "%" + searchParameter + "%";
                    p2.Value = "%" + searchParameter2 + "%";
                    p.ParameterName = "@searchParameter";
                    p2.ParameterName = "@searchParameter2";
                    string query = "SELECT p.FirstName, p.LastName, s.SubjectName  FROM Professors p, Subjects s   WHERE p.SubjectID=s.SubjectID AND LastName LIKE @searchParameter AND FirstName LIKE @searchParameter2";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p);
                    cmd.Parameters.Add(p2);
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception Message " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace " + ex.StackTrace);
            }
        }
    }
}