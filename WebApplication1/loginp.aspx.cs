using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;

namespace WebApplication1
{
    public partial class loginp : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-KIJ0JR6; Initial Catalog=academica; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void loginbtn_Click1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from usuario where usuario = '" + txtusuario.Text + "' and password= '" + txtclave.Text + "'", conexion);
            SqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Write("<scrip>alert('Datos Erroneros');</script>");

            }
        }
    }
} 