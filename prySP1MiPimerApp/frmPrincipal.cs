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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        

        private void btnAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena alacena = new frmAlacena();
            alacena.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            frmGestordeGastos Gestor = new frmGestordeGastos();
            Gestor.ShowDialog();
        }
    }
}
