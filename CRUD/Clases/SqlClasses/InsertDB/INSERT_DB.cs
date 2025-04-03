using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases.SqlClasses.InsertDB
{
    internal class INSERT_DB
    {

        protected static string db = @"Data Source = DESKTOP-NI11EM0; Initial Catalog = losquatrohermanos; integrated security = true";
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd;

        public static void InsertDB(List<TextBox> textBox, ComboBox boxprovee, ComboBox boxtipo) //Metodo insertar
        {
            try
            {
                Itcontrols.take_values(textBox);

                string insertQry = "insert into Productos values(" + Itcontrols.compile_values[0] + ",'" + Itcontrols.compile_values[1] + "'," + boxprovee.SelectedIndex + " ," + (boxtipo.SelectedIndex + 1) + ") " +
                                   "insert into Producto_Precio values(" + Itcontrols.compile_values[0] + ", " + Itcontrols.compile_values[4] + ") " +
                                   "insert into Producto_coste values(" + boxprovee.SelectedIndex + ", " + Itcontrols.compile_values[0] + ", " + Itcontrols.compile_values[5] + ") ";

                cmd = new SqlCommand(insertQry, ConnectinDB.opencnn(con));
                cmd.ExecuteNonQuery();
                Bntmethods.Clrtxt(textBox);
                MessageBox.Show("Se insertaron valores en la base de datos");
                ConnectinDB.closecnn(con);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya hay un objeto existente en la base de datos");
                ConnectinDB.closecnn(con);
            }
        }

    }
}
