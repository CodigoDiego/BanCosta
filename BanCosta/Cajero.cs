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
    public partial class Cajero : Form
    {
        Button btnActive;
        public Usuarios UsuarioActual = new Usuarios();        
        public Frm_Login FrmTmp;
        public Cajero()
        {
            InitializeComponent();
        }

        public Form ActiveForm = null;

        public void openChildForm(FormTemporal childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.FormTmp = this;
            childForm.UsuarioActual = UsuarioActual;
            childForm.banCosta = FrmTmp.banCosta;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            FrmTmp.Carga_Json();
            lbl_bienv.Text = "Bienvenido a BanCosta, "+UsuarioActual.Nombre;
            lbl_bienv.AutoSize = false;

        }

        private void Cajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.form1.Show();
        }


        public void btn_dep_Click(object sender, EventArgs e)
        {

            openChildForm(new Cajero_deposito());
        }

        private void btn_retiro_Click(object sender, EventArgs e)
        {
            openChildForm(new Cajero_retiro());
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_mnl_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btn_hist_Click(object sender, EventArgs e)
        {
            openChildForm(new Cajero_historial());
        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }
    }
}
