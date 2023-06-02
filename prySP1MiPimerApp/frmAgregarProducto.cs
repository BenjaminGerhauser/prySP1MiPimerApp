using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1MiPimerApp
{
    public partial class frmAgregar : Form
    {

        //variables
         
        string varubicacion, varcategoria, varproducto, varcantidad;

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cboCategoria.Text)
            {
                case "Limpieza":
                    cboProducto.Items.Clear();

                    cboProducto.Items.Add("Lavandina");
                    cboProducto.Items.Add("Detergente");
                    cboProducto.Items.Add("Esponjas");
                    cboProducto.Items.Add("Desodorantede ambiente");
                    cboProducto.Items.Add("Desengrasante");
                    break;
                case "Comida":
                    cboProducto.Items.Clear();

                    cboProducto.Items.Add("Milanesas");
                    cboProducto.Items.Add("Lechuga");
                    cboProducto.Items.Add("Arroz");
                    cboProducto.Items.Add("Tomate");
                    break;
                case "Congelados":
                    cboProducto.Items.Clear();

                    cboProducto.Items.Add("Pizza");
                    cboProducto.Items.Add("Ravioles");
                    cboProducto.Items.Add("Carne");
                    cboProducto.Items.Add("Pescado");

                    break;
                case "Enlatados":
                    cboProducto.Items.Clear();

                    cboProducto.Items.Add("Atun");
                    cboProducto.Items.Add("Lentejas");
                    cboProducto.Items.Add("Arvejas");
                    cboProducto.Items.Add("Choclo");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmAlacena alacena = new frmAlacena();
            alacena.ShowDialog();   
        }

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            varcategoria = cboCategoria.Text;
            varproducto = cboProducto.Text;
            varcantidad = Convert.ToString(numericUDcantidad.Value);
            varubicacion = cboUbicacion.Text;
            cboProducto.Items.Clear();
                        
        }
    }
}
