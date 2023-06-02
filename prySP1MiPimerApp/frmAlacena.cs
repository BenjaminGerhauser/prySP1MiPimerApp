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
    public partial class frmAlacena : Form
    {
        public frmAlacena()
        {
            InitializeComponent();
        }

        

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCongelados_Click(object sender, EventArgs e)
        {
           // frmAgregar congelados = new frmAgregar();
            //congelados.ShowDialog();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            //frmAgregar comida = new frmAgregar();
            //comida.ShowDialog();
        }

        private void btnBaño_Click(object sender, EventArgs e)
        {
            //frmAgregar baño = new frmAgregar();
            //baño.ShowDialog();
        }

        private void btnHeladera_Click(object sender, EventArgs e)
        {
            //frmAgregar heladera= new frmAgregar();
            //heladera.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }
    }
}
