using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases
{
    //CLASE PARA ITERAR SOBRE LOS CONTROLES DE LOS FORMS
    internal class Itcontrols
    {
        //
        public static List<object> compile_values = new List<object>();


        public static List<TextBox> GetTotalTextBoxes(Control control) //Obtiene todos los texboxs
        {
            
            List<TextBox> txtarray = new List<TextBox>();

            for (int count = 0; count <= control.Controls.Count - 1; count++)
            {
                if (control.Controls[count] is System.Windows.Forms.TextBox)
                {
                    txtarray.Add((TextBox)control.Controls[count]);
                }
            }

            txtarray.Reverse();
            return txtarray;
        }

        public static void fill_txt(List<TextBox> textBox, SqlDataReader rq) //Metodo llenar textboxs
        {

            int count = textBox.Count - (textBox.Count - rq.FieldCount);

            for (int i = 0; i <= count; i++)
            {

                if (i != 0 && i <= count)
                {

                    textBox[i].Text = Convert.ToString(rq[i - 1]);

                }

            }
        }


        public static void take_values(List<TextBox> textBox) //Metodo tomar valores de los textboxs
        {

            for (int i = 0; i <= textBox.Count - 1; i++)
            {
                compile_values.Add(textBox[i].Text);
            }
        }

        public static void Filldgv(DataGridView dataGrid, SqlDataReader reader) //metodo para llenar el dgv
        {
            while (reader.Read())
            {
                dataGrid.Rows.Add();
                int count = dataGrid.Rows.Count - 1;

                dataGrid[0, count].Value = reader["Id_pro"];
                dataGrid[1, count].Value = reader["nom_pro"];
                dataGrid[2, count].Value = reader["Id_proveedor"];
                dataGrid[3, count].Value = reader["Id_tipo"];
                dataGrid[4, count].Value = reader["fecha"];

            }

          
        }
    
        public static void clearlist(List<Object> ls) //Metodo para limpiar la lista compile values
        {
            ls.Clear();
        }
    }
}
