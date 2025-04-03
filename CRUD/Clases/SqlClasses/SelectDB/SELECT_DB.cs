using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases.SqlClasses.SelectDB
{
    internal class SELECT_DB
    {
        protected static string db = @"Data Source = DESKTOP-NI11EM0; Initial Catalog = losquatrohermanos; integrated security = true";
        protected static SqlConnection con = new SqlConnection();
        protected static SqlCommand cmd;

        public static void SelectDB(List<TextBox> textBox, TextBox textinput) //Metodo consultar
        {



            string Query = "select Productos.Nom_Producto , Producto_tipo.tipo, Proveedor.proveedor, " +
                            "Producto_Precio.Precio, Producto_coste.Coste_docena " +
                            "from Productos " +
                            "JOIN Proveedor ON Productos.Id_proveedor = Proveedor.Id_proveedor " +
                            "JOIN Producto_tipo ON Productos.Id_tipo = Producto_tipo.Id_tipo " +
                            "JOIN Producto_coste ON Producto_coste.Id_producto = Productos.Id_Producto " +
                            "JOIN Producto_Precio ON Producto_Precio.Id_Producto = Productos.Id_Producto " +
                            "WHERE Productos.Id_Producto = " + textinput.Text + "";

            Bntmethods.Clrtxt(textBox);

            cmd = new SqlCommand(Query, ConnectinDB.opencnn(con));
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                Itcontrols.fill_txt(textBox, rcd);
            }

            ConnectinDB.closecnn(con);
        }


    }
}
