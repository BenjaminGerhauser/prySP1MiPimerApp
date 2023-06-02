namespace prySP1MiPimerApp
{
    partial class frmPrincipal
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
            this.btnAlacena = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlacena
            // 
            this.btnAlacena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlacena.Location = new System.Drawing.Point(171, 35);
            this.btnAlacena.Name = "btnAlacena";
            this.btnAlacena.Size = new System.Drawing.Size(138, 122);
            this.btnAlacena.TabIndex = 0;
            this.btnAlacena.Text = "Alacena";
            this.btnAlacena.UseVisualStyleBackColor = false;
            this.btnAlacena.Click += new System.EventHandler(this.btnAlacena_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGastos.Location = new System.Drawing.Point(27, 35);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(138, 122);
            this.btnGastos.TabIndex = 1;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(341, 193);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnAlacena);
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlacena;
        private System.Windows.Forms.Button btnGastos;
    }
}