using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases
{   
    //Clase para inicalizar componentes
    internal class InitCompnts
    {
        //METODO PARA INICIALIZAR DGV DE PRODUCTOS ELIMINADOS
        public static void dgveliminados(DataGridView dataGrid)
        {

            dataGrid.Name = "productos eliminados";
            dataGrid.ColumnCount = 6;
            dataGrid.RowHeadersVisible = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGrid.BorderStyle = BorderStyle.None;


            dataGrid.Columns[0].Name = "Idproducto";
            dataGrid.Columns[1].Name = "nom";
            dataGrid.Columns[2].Name = "Idproveedor";
            dataGrid.Columns[3].Name = "Idtipo";
            dataGrid.Columns[4].Name = "fecha";

            DataGridViewColumn
            column = dataGrid.Columns[0]; column.Width = 65;
            column = dataGrid.Columns[1]; column.Width = 80;
            column = dataGrid.Columns[2]; column.Width = 60;
            column = dataGrid.Columns[3]; column.Width = 50;
            column = dataGrid.Columns[4]; column.Width = 100;

        }
    }
}
