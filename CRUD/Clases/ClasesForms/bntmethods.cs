using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases
{
    //CLASE CONTIENE METODOS DE LOS BOTONES 
    internal class Bntmethods
    {
        //METODO PARA LIMPIAR TEXTBOXS
        public static void Clrtxt(List<TextBox> txtarray) //Limpia los textboxs
        {
            foreach (TextBox txt in txtarray)
            {
                txt.Clear();
            }

            
           
        }

    }   
}
