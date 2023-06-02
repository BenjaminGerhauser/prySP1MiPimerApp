namespace prySP1MiPimerApp
{
    partial class frmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.mrcTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.numericUDcantidad = new System.Windows.Forms.NumericUpDown();
            this.mrcTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 90);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 142);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 195);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(12, 241);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // mrcTitulo
            // 
            this.mrcTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.mrcTitulo.Controls.Add(this.lblTitulo);
            this.mrcTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mrcTitulo.Location = new System.Drawing.Point(-6, -7);
            this.mrcTitulo.Name = "mrcTitulo";
            this.mrcTitulo.Size = new System.Drawing.Size(241, 69);
            this.mrcTitulo.TabIndex = 4;
            this.mrcTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitulo.Location = new System.Drawing.Point(67, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(15, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(143, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Limpieza",
            "Comida",
            "Congelados",
            "Enlatados"});
            this.cboCategoria.Location = new System.Drawing.Point(85, 90);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 12;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(85, 142);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 13;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Items.AddRange(new object[] {
            "Heladera",
            "Freezer",
            "Alacena",
            "Baño"});
            this.cboUbicacion.Location = new System.Drawing.Point(85, 238);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cboUbicacion.TabIndex = 14;
            // 
            // numericUDcantidad
            // 
            this.numericUDcantidad.Location = new System.Drawing.Point(87, 192);
            this.numericUDcantidad.Name = "numericUDcantidad";
            this.numericUDcantidad.Size = new System.Drawing.Size(118, 20);
            this.numericUDcantidad.TabIndex = 16;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(228, 370);
            this.Controls.Add(this.numericUDcantidad);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mrcTitulo);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCategoria);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.Text = "Agregar Producto";
            this.mrcTitulo.ResumeLayout(false);
            this.mrcTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.GroupBox mrcTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.NumericUpDown numericUDcantidad;
    }
}