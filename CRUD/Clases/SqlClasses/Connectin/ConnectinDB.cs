using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace CRUD.Clases
{
    public class ConnectinDB
    {
        protected static string db = @"Data Source = DESKTOP-NI11EM0; Initial Catalog = losquatrohermanos; integrated security = true";
        //Metodos
        public static SqlConnection opencnn(SqlConnection con) //Metodo abrir base de datos
        {
            con.ConnectionString = db;
            con.Open();

            return con;
        }

        public static void closecnn(SqlConnection con)//Metodo cerrar base de datos
        {
            con.Close();
        }

    }
}
