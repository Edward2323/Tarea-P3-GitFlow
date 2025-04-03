using CRUD.Clases;
using CRUD.Clases.SqlClasses.LoginSL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Formularios
{
    public partial class frmLogin : Form
    {
        frmMP frmMP = new frmMP();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (LoginSL.Login(Itcontrols.GetTotalTextBoxes(this))) //Valida el inicio de sesion
            {
                frmMP.Show();
                this.Hide();
            }
            else
            {
                lbMessage.Text = "Usuario o contraseña incorrectos";
                lbMessage.ForeColor = Color.Red;
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //Cierra el formulario
        {
            Close();
        }
    }
}
