using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanCosta
{
    public partial class Cajero_historial : FormTemporal
    {
        Cajero_retiro retTemp = new Cajero_retiro();
        Cajero_deposito Cajdeptmp = new Cajero_deposito();
        public Cajero_historial()
        {
            InitializeComponent();
            UsuarioActual = new Usuarios();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cajero_historial_Load(object sender, EventArgs e)
        {
            retTemp.ActualizaClase();
            dgv_historial.Dock = DockStyle.Fill;
            //dgv_historial.DataSource = UsuarioActual.Cuenta.Movimientos;
            UsuarioActual = banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta);
            dgv_historial.DataSource = UsuarioActual.Cuenta.Movimientos.Select(x => x.Source).ToList();            

            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
