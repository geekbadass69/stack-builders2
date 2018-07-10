using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace stackbuilders
{
    public partial class test : System.Web.UI.Page
    {

        string connDB = System.Configuration.ConfigurationManager.ConnectionStrings["info"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection info_Conn = new SqlConnection(connDB))
            {
                using (SqlCommand info_cmd = new SqlCommand("dbo.getallinfo", info_Conn))
                {
                    info_cmd.CommandType = CommandType.Text;
                    info_cmd.CommandTimeout = 0;

                    info_Conn.Open();

                    using (SqlDataReader info_Reader = info_cmd.ExecuteReader())
                    {
                        if (info_Reader.Read())
                        {
                            allinfogrd.DataSource = info_Reader;
                            allinfogrd.DataBind();
                        }
                    }
                }

            }
        }
    }
}