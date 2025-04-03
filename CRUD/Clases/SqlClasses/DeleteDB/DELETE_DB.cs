using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases.SqlClasses.DeleteDB
{

    internal class DELETE_DB
    {
        protected static string db = @"Data Source = DESKTOP-NI11EM0; Initial Catalog = losquatrohermanos; integrated security = true";
        protected static SqlConnection con = new SqlConnection();
        protected static SqlCommand cmd;
        protected static SqlDataReader reader;


        public static void DeleteDB(List<TextBox> txtarray, DataGridView dataGrid) //Metodo eliminar
        {
            Itcontrols.take_values(txtarray);

            string deleteQry = "DELETE FROM Producto_Precio WHERE Id_Producto = " + Itcontrols.compile_values[0] + " " +
                               "DELETE FROM Producto_coste WHERE Id_Producto =  " + Itcontrols.compile_values[0] + " " +
                               "DELETE FROM Productos WHERE Id_Producto = " + Itcontrols.compile_values[0] + " ";

            cmd = new SqlCommand(deleteQry, ConnectinDB.opencnn(con));
            cmd.ExecuteNonQuery();

            Bntmethods.Clrtxt(txtarray);
            ConnectinDB.closecnn(con);
            Selectpro_dlt(dataGrid);
            MessageBox.Show("Se elimaron los registros de base de datos");
        }

        public static void Selectpro_dlt(DataGridView dataGrid) //METODO PARA LLENAR EL DGV CON PRODUCTOS ELIMINADOS
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
            string selectqry = "SELECT * FROM pro_eliminados";

            cmd = new SqlCommand(selectqry, ConnectinDB.opencnn(con));
            reader = cmd.ExecuteReader();
            Itcontrols.clearlist(Itcontrols.compile_values);
            Itcontrols.Filldgv(dataGrid, reader);
            ConnectinDB.closecnn(con);
        }




    }
}
