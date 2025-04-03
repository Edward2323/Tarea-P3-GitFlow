using CRUD.Clases;
using System;
using System.Windows.Forms;
using CRUD.Clases.SqlClasses.DeleteDB;
using CRUD.Clases.SqlClasses.InsertDB;
using CRUD.Clases.SqlClasses.SelectDB;


namespace CRUD
{

    public partial class frmMP : Form
    {
        //Atributos y objetos
        protected ConnectinDB conectar = new ConnectinDB();
        protected SecurityMethodsSLCT securitySLCT = new SecurityMethodsSLCT();
        protected SecuritymethodsINSRT securityINSRT = new SecuritymethodsINSRT();
        public Control.ControlCollection control;

        //Metodos
        public frmMP() //Metodo constructor
        {
            InitializeComponent();
            InitCompnts.dgveliminados(dgvpro_eliminados);
            DELETE_DB.Selectpro_dlt(dgvpro_eliminados);
        }


        private void btnSelect_Click_1(object sender, EventArgs e) //Boton consultar
        {


            if (securitySLCT.Ensure_txt(txtIdproducto, txtPrecio, txtCostedocena))
            {
                SELECT_DB.SelectDB(Itcontrols.GetTotalTextBoxes(this), txtIdproducto);
            }
            else
            {
                txtIdproducto.Clear();
                txtIdproducto.Focus();
            }

        }

        private void btnInsert_Click(object sender, EventArgs e) //Boton insertar
        {

            if (txtIdproducto.Text == "" || txtNomproducto.Text == "" || txtPrecio.Text == "" ||
                txtCostedocena.Text == "" || cbprovee.SelectedIndex == -1 || cbtipo.SelectedIndex == -1)
            {
                MessageBox.Show("Rellene todos los campos");

                if (txtIdproducto.Text != "")
                {
                    cbprovee.Focus();
                }

                else
                {
                    txtIdproducto.Focus();
                }
            }

            else
            {
                if (securityINSRT.Ensure_txt(txtIdproducto, txtPrecio, txtCostedocena))
                {
                    INSERT_DB.InsertDB(Itcontrols.GetTotalTextBoxes(this), cbprovee, cbtipo);
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e) //Boton borrar
        {
            if (txtIdproducto.Text != "")
            {
                if (securitySLCT.Ensure_txt(txtIdproducto, txtPrecio, txtCostedocena))
                {
                    DELETE_DB.DeleteDB(Itcontrols.GetTotalTextBoxes(this), dgvpro_eliminados);
                }

                else
                {
                    txtIdproducto.Clear();
                }

            }

            else
            {
                MessageBox.Show("Inserte el id del producto");
                txtIdproducto.Focus();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e) //Boton Limpiar
        {
            Bntmethods.Clrtxt(Itcontrols.GetTotalTextBoxes(this));
        }

    }
}
