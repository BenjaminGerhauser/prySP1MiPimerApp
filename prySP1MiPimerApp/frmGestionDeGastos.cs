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
    public partial class frmGestordeGastos : Form
    {

        //declaracion de variables
        decimal varDeposito;
        decimal varAlquiler, varIntereses, varComida, varSaldoDisponible;


        public frmGestordeGastos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSaldoDisponible_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //aa
        }

        private void lblSaldoFinal_Click(object sender, EventArgs e)
        {

        }

        private void frmGestordeGastos_Load(object sender, EventArgs e)
        {
            //inicializar variables
            varAlquiler = 0;
            varComida = 0;
            varDeposito = 0;
            varIntereses = 0;
            varSaldoDisponible = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varIntereses = Convert.ToDecimal(txtIntereses.Text);
            varDeposito = Convert.ToDecimal(txtIngreso.Text);

            varSaldoDisponible = varDeposito - (varAlquiler + varComida + varIntereses);
            lblSaldoFinal.Text = varSaldoDisponible.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            varAlquiler = 0;
            varDeposito = 0;
            varIntereses = 0;
            varDeposito = 0;
            lblSaldoFinal.Text = "0";
        }
    }
}
