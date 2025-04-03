using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD.Clases.SqlClasses.LoginSL
{
    
    internal class LoginSL
    {
        public static List<object> compile_values = new List<object>();
        protected static SqlConnection con = new SqlConnection();
        protected static SqlCommand cmd;
        protected static SqlDataReader rcd;

        public static bool Login(List<TextBox> txt) //Metodo para validar el usuario
        {
            Itcontrols.take_values(txt);

            string qry = "SELECT * FROM Empleados_Usuarios WHERE Usuario = '"+ Itcontrols.compile_values[0] + 
                         "' AND contra = '" + Itcontrols.compile_values[1] + "'";

            cmd = new SqlCommand(qry, ConnectinDB.opencnn(con));
            rcd = cmd.ExecuteReader();
            Itcontrols.clearlist(Itcontrols.compile_values);

            if (rcd.Read())
            {
                ConnectinDB.closecnn(con);
                return true;
                
            }
            else
            {
                ConnectinDB.closecnn(con);
                return false;
            }
            
        }
    }
}
 