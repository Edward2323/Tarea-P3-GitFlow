using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Clases
{
    public abstract class Abstract_SecurityMethods
    {
        public abstract bool Ensure_txt(TextBox Id, TextBox precio, TextBox coste);
    }
}
