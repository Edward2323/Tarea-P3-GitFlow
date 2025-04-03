using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases.SqlClasses.SelectDB
{
    public class SecurityMethodsSLCT : Abstract_SecurityMethods
    {
        public override bool Ensure_txt(TextBox id, TextBox precio, TextBox coste)
        {
            try
            {
                int com = Convert.ToInt32(id.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserte el valor indicado");
                return false;
            }
        }

    }
}
