using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CRUD.Clases.SqlClasses.InsertDB
{
    public class SecuritymethodsINSRT : Abstract_SecurityMethods
    {

        public override bool Ensure_txt(TextBox id, TextBox precio, TextBox coste)
        {
            try
            {
                uint com = Convert.ToUInt32(id.Text);
                uint com2 = Convert.ToUInt32(precio.Text);
                uint com3 = Convert.ToUInt32(coste.Text);
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
