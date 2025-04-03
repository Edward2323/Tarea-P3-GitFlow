namespace CRUD
{
    partial class frmMP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMP));
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.txtNomproducto = new System.Windows.Forms.TextBox();
            this.txtTipoproducto = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCostedocena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvpro_eliminados = new System.Windows.Forms.DataGridView();
            this.lbproductoseliminados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.cbprovee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro_eliminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.Location = new System.Drawing.Point(10, 189);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(105, 26);
            this.txtIdproducto.TabIndex = 0;
            // 
            // txtNomproducto
            // 
            this.txtNomproducto.Location = new System.Drawing.Point(9, 264);
            this.txtNomproducto.Name = "txtNomproducto";
            this.txtNomproducto.Size = new System.Drawing.Size(140, 26);
            this.txtNomproducto.TabIndex = 1;
            // 
            // txtTipoproducto
            // 
            this.txtTipoproducto.Location = new System.Drawing.Point(9, 626);
            this.txtTipoproducto.Name = "txtTipoproducto";
            this.txtTipoproducto.Size = new System.Drawing.Size(140, 26);
            this.txtTipoproducto.TabIndex = 2;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(9, 699);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(116, 26);
            this.txtProveedor.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(10, 329);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(75, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCostedocena
            // 
            this.txtCostedocena.Location = new System.Drawing.Point(10, 400);
            this.txtCostedocena.Name = "txtCostedocena";
            this.txtCostedocena.Size = new System.Drawing.Size(75, 26);
            this.txtCostedocena.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Coste Docena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id proveedor";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(217, 312);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(219, 49);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Consultar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(217, 377);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(219, 49);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(219, 50);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id tipo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(237, 513);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(169, 50);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvpro_eliminados
            // 
            this.dgvpro_eliminados.AllowUserToAddRows = false;
            this.dgvpro_eliminados.AllowUserToDeleteRows = false;
            this.dgvpro_eliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpro_eliminados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvpro_eliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpro_eliminados.Location = new System.Drawing.Point(492, 176);
            this.dgvpro_eliminados.Name = "dgvpro_eliminados";
            this.dgvpro_eliminados.ReadOnly = true;
            this.dgvpro_eliminados.RowHeadersWidth = 62;
            this.dgvpro_eliminados.RowTemplate.Height = 28;
            this.dgvpro_eliminados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvpro_eliminados.Size = new System.Drawing.Size(539, 520);
            this.dgvpro_eliminados.TabIndex = 27;
            // 
            // lbproductoseliminados
            // 
            this.lbproductoseliminados.AutoSize = true;
            this.lbproductoseliminados.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductoseliminados.Location = new System.Drawing.Point(643, 142);
            this.lbproductoseliminados.Name = "lbproductoseliminados";
            this.lbproductoseliminados.Size = new System.Drawing.Size(278, 30);
            this.lbproductoseliminados.TabIndex = 28;
            this.lbproductoseliminados.Text = "Productos eliminados";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Aqua;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-181, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1422, 131);
            this.label10.TabIndex = 29;
            this.label10.Text = "CRUD Productos LQH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 79);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Embutidos",
            "Verduras",
            "Frutas",
            "Limpieza",
            "Higiene",
            "Bebidas",
            "Chips",
            "Snacks"});
            this.cbtipo.Location = new System.Drawing.Point(10, 551);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 28);
            this.cbtipo.TabIndex = 31;
            this.cbtipo.Text = "Tipo";
            // 
            // cbprovee
            // 
            this.cbprovee.FormattingEnabled = true;
            this.cbprovee.Items.AddRange(new object[] {
            "Rica",
            "Induveca",
            "Gilleta",
            "Colgate",
            "Suplisol S.R.L"});
            this.cbprovee.Location = new System.Drawing.Point(10, 471);
            this.cbprovee.Name = "cbprovee";
            this.cbprovee.Size = new System.Drawing.Size(121, 28);
            this.cbprovee.TabIndex = 32;
            this.cbprovee.Text = "Proveedor";
            // 
            // frmMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 748);
            this.Controls.Add(this.cbprovee);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbproductoseliminados);
            this.Controls.Add(this.dgvpro_eliminados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostedocena);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtTipoproducto);
            this.Controls.Add(this.txtNomproducto);
            this.Controls.Add(this.txtIdproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD productos LQH";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro_eliminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.TextBox txtNomproducto;
        private System.Windows.Forms.TextBox txtTipoproducto;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCostedocena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvpro_eliminados;
        private System.Windows.Forms.Label lbproductoseliminados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.ComboBox cbprovee;
    }
}

