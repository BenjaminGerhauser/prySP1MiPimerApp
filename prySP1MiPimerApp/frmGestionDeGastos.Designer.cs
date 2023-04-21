namespace prySP1MiPimerApp
{
    partial class frmGestordeGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestordeGastos));
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcSaldoDisponible = new System.Windows.Forms.GroupBox();
            this.lblSaldoDisponible = new System.Windows.Forms.Label();
            this.mrcGastos.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.mrcSaldoDisponible.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIngreso.Location = new System.Drawing.Point(6, 27);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(64, 17);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Depósito";
            this.lblIngreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(90, 27);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(126, 23);
            this.txtIngreso.TabIndex = 1;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(116, 31);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 23);
            this.txtAlquiler.TabIndex = 2;
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(116, 84);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(100, 23);
            this.txtIntereses.TabIndex = 3;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(116, 132);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 23);
            this.txtComida.TabIndex = 4;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlquiler.Location = new System.Drawing.Point(27, 34);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(55, 17);
            this.lblAlquiler.TabIndex = 5;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIntereses.Location = new System.Drawing.Point(27, 87);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(66, 17);
            this.lblIntereses.TabIndex = 6;
            this.lblIntereses.Text = "Intereses";
            this.lblIntereses.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComida.Location = new System.Drawing.Point(27, 135);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(55, 17);
            this.lblComida.TabIndex = 7;
            this.lblComida.Text = "Comida";
            // 
            // mrcGastos
            // 
            this.mrcGastos.Controls.Add(this.lblComida);
            this.mrcGastos.Controls.Add(this.lblIntereses);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Controls.Add(this.txtComida);
            this.mrcGastos.Controls.Add(this.txtIntereses);
            this.mrcGastos.Controls.Add(this.txtAlquiler);
            this.mrcGastos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mrcGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mrcGastos.Location = new System.Drawing.Point(37, 136);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(256, 172);
            this.mrcGastos.TabIndex = 8;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "Gastos";
            this.mrcGastos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtIngreso);
            this.mrcIngresos.Controls.Add(this.lblIngreso);
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mrcIngresos.Location = new System.Drawing.Point(37, 29);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(256, 67);
            this.mrcIngresos.TabIndex = 9;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(37, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 35);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(218, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mrcSaldoDisponible
            // 
            this.mrcSaldoDisponible.Controls.Add(this.lblSaldoDisponible);
            this.mrcSaldoDisponible.Location = new System.Drawing.Point(37, 425);
            this.mrcSaldoDisponible.Name = "mrcSaldoDisponible";
            this.mrcSaldoDisponible.Size = new System.Drawing.Size(256, 37);
            this.mrcSaldoDisponible.TabIndex = 13;
            this.mrcSaldoDisponible.TabStop = false;
            // 
            // lblSaldoDisponible
            // 
            this.lblSaldoDisponible.AutoSize = true;
            this.lblSaldoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSaldoDisponible.Location = new System.Drawing.Point(6, 13);
            this.lblSaldoDisponible.Name = "lblSaldoDisponible";
            this.lblSaldoDisponible.Size = new System.Drawing.Size(120, 17);
            this.lblSaldoDisponible.TabIndex = 10;
            this.lblSaldoDisponible.Text = "Saldo disponible: ";
            // 
            // frmGestordeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(325, 488);
            this.Controls.Add(this.mrcSaldoDisponible);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcIngresos);
            this.Controls.Add(this.mrcGastos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestordeGastos";
            this.Text = "Gestor de gastos mensuales";
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcSaldoDisponible.ResumeLayout(false);
            this.mrcSaldoDisponible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox mrcSaldoDisponible;
        private System.Windows.Forms.Label lblSaldoDisponible;
    }
}

