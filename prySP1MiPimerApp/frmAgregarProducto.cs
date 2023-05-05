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

        //declaracion de variables
        string varcategoria, varproducto, varubicacion;
        int varcantidad;
 
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            varcategoria = cboCategoria.Text;
            varproducto = cboProducto.Text;
            varcantidad = Convert.ToInt32(txtCantidad.Text);
            varubicacion = cboUbicacion.Text;
            lstVariedad.Items.Add(varcategoria + " " + varproducto + " " + varcantidad + " " + varubicacion);
            
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            cboProducto.Items.Add("Azucar");
            cboProducto.Items.Add("Milanesa");
            cboProducto.Items.Add("Té");
            cboProducto.Items.Add("Carne");
            cboProducto.Items.Add("Yerba");
            cboProducto.Items.Add("Trapo");
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
