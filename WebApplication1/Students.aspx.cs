using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (con)
                {
                    con.Open();
                    string query = "SELECT s.FirstName, s.LastName, h.HouseName  FROM Students s, Houses h  WHERE h.HouseID=s.HouseID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    reader.Close();
                }
            }
            else
            {
                Button1_Click(sender, e);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    string searchParameter = TextBox1.Text.Trim();
                    string searchParameter2 = TextBox2.Text.Trim();
                    string searchParameter3 = DropDownList1.SelectedValue.ToString();
                    GridView1_Show(con, searchParameter, searchParameter2, searchParameter3);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception Message " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace " + ex.StackTrace);
            }
        }

        void GridView1_Show(SqlConnection con, string searchParameter, string searchParameter2, string searchParameter3)
        {
            SqlParameter p = new SqlParameter();
            SqlParameter p2 = new SqlParameter();
            SqlParameter p3 = new SqlParameter();
            p.Value = "%" + searchParameter + "%";
            p2.Value = "%" + searchParameter2 + "%";
            p3.Value = searchParameter3;
            p.ParameterName = "@searchParameter";
            p2.ParameterName = "@searchParameter2";
            p3.ParameterName = "@searchParameter3";
            string query = "SELECT s.FirstName, s.LastName, h.HouseName   FROM Students s, Houses h  WHERE h.HouseID=s.HouseID AND LastName LIKE @searchParameter AND FirstName LIKE @searchParameter2 AND h.HouseName=@searchParameter3";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
        }
    }
}