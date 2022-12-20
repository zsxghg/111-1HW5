using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace _111_1HW5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection s_Conn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLLOCAL"].ConnectionString);
            protected void Page_Load(object sender, EventArgs e)
            {
                try
                {
                    s_Conn.Open();
                    SqlDataAdapter o_A = new SqlDataAdapter("Select * from Users", s_Conn);
                    DataSet o_D = new DataSet();
                    o_A.Fill(o_D, "talk");
                    gd_View.DataSource = o_D;
                    gd_View.DataBind();
                    s_Conn.Close();
                }
                catch (Exception o_exc)
                {
                    Response.Write(o_exc.ToString());
                }
            }

            protected System.Void btn_Insert_Click()
            {
                try
                {
                    s_Conn.Open();
                    SqlCommand s_sql = new SqlCommand("Insert into Users (Name, Birthday)" + "values(@Name, @DateTime)", s_Conn);
                    o_cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 20);
                    o_cmd.Parameters["@Name"].Value = "阿貓阿狗";
                    o_cmd.Parameters.Add("@DateTime", SqlDbType.DateTime);
                    o_cmd.Parameters["@DateTime"].Value = "2012/8/2";
                    int i_flag = o_cmd.ExecuteNonQuery();
                    s_Conn.Close();
                }
                catch (Exception o_tes) 
                {
                    Response.Write(o_tes.ToString());
                }
            }
        }
    }
}