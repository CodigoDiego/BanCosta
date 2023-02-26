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
    public partial class AdminCon : Form
    {
        Edit EditarUsr = new Edit();
        Registro Addusr = new Registro();
        public List<Usuarios> listUsrs = new List<Usuarios>();
        //AdminCon admintmp = new AdminCon();
        public AdminCon()
        {
            InitializeComponent();
        }

        private void AdminCon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form1.Show();
        }

        private void btn_add_usr_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Addusr.Show();
        }

        private void AdminCon_Load(object sender, EventArgs e)
        {

        }

        private void btn_elim_usr_Click(object sender, EventArgs e)
        {
        }

        private void btn_edit_usr_Click(object sender, EventArgs e)
        {
            this.Visible =false;
            EditarUsr.listUsrs = listUsrs;
            EditarUsr.Show();
        }
        }
    }
