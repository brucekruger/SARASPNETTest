using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SARASPNETTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLAzure"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Table", conn);
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
    }
}
