namespace prySP1MiPimerApp
{
    partial class frmAlacena
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaño = new System.Windows.Forms.Button();
            this.btnHeladera = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnCongelados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarProducto.Location = new System.Drawing.Point(100, 349);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(123, 55);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alacena";
            // 
            // btnBaño
            // 
            this.btnBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBaño.Location = new System.Drawing.Point(172, 224);
            this.btnBaño.Name = "btnBaño";
            this.btnBaño.Size = new System.Drawing.Size(107, 64);
            this.btnBaño.TabIndex = 2;
            this.btnBaño.Text = "Baño";
            this.btnBaño.UseVisualStyleBackColor = true;
            // 
            // btnHeladera
            // 
            this.btnHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHeladera.Location = new System.Drawing.Point(38, 224);
            this.btnHeladera.Name = "btnHeladera";
            this.btnHeladera.Size = new System.Drawing.Size(107, 64);
            this.btnHeladera.TabIndex = 3;
            this.btnHeladera.Text = "Heladera";
            this.btnHeladera.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnComida.Location = new System.Drawing.Point(172, 92);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(107, 64);
            this.btnComida.TabIndex = 4;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnCongelados
            // 
            this.btnCongelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCongelados.Location = new System.Drawing.Point(38, 92);
            this.btnCongelados.Name = "btnCongelados";
            this.btnCongelados.Size = new System.Drawing.Size(107, 64);
            this.btnCongelados.TabIndex = 5;
            this.btnCongelados.Text = "Congelados";
            this.btnCongelados.UseVisualStyleBackColor = true;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.btnCongelados);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btnHeladera);
            this.Controls.Add(this.btnBaño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaño;
        private System.Windows.Forms.Button btnHeladera;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnCongelados;
    }
}