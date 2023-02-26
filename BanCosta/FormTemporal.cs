using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanCosta
{
    public class FormTemporal : Form
    {
        public Cajero FormTmp { get; set; }
        public Usuarios UsuarioActual { get; set; }
        public Banco banCosta = new Banco();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormTemporal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormTemporal";
            this.Load += new System.EventHandler(this.FormTemporal_Load);
            this.ResumeLayout(false);

        }

        private void FormTemporal_Load(object sender, EventArgs e)
        {

        }
    }
}
