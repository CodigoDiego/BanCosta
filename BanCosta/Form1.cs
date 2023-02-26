using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BanCosta
{
    public partial class Frm_Login : Form
    {

        //Se crea una instancia de la lista que existe en el otro Form
        //List<Usuarios> listUsrs = new List<Usuarios>();


        //Se copia la lista anterior pero dentro de otro objeto
        Registro RegistroTemp = new Registro();

        /*BANCOSTA PRINCIPAL*/
        public Banco banCosta = new Banco();
        public string nCuenProv = "";
        int intentos = 0;

        public Frm_Login()              //List<Usuarios> lstusrs
        {
            InitializeComponent();
                                         //listUsrs = lstusrs;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Carga_Json();
        }

        public void Carga_Json()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DatosBancosta.json";

            banCosta = new Banco();
            try
            {
                using (StreamReader archivo = new StreamReader(@ruta))
                {
                    JavaScriptSerializer jssAbre = new JavaScriptSerializer();
                    jssAbre.MaxJsonLength = 2147483644;

                    banCosta = jssAbre.Deserialize<Banco>(archivo.ReadLine());

                    archivo.Close();
                }
            }
            catch(Exception ex) { banCosta = new Banco(); }
        }

        private void tb_user_Click(object sender, EventArgs e)
        {
            
        }

        //Mostrando un formulario con un botón
        private void lbl_rgstr_Click(object sender, EventArgs e)
        {

            //Form que contiene la lista de clases de usuarios

            this.Hide();
            //if (RegistroTemp == null)
            //{

            // }
            RegistroTemp = new Registro();
            
            RegistroTemp.FrmTmp = this;
            RegistroTemp.Show();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mt_nCuenta.Select(0, 0);
        }

        private void msk_tb_nip_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msk_tb_nip.Select(0, 0);
        }
        public void Actualiza_Banco()
        {
            Carga_Json();
        }
        public void btn_entr_Click(object sender, EventArgs e)
        {
            //
            bool nipVacio=false;
            bool nCuenVacio=false;
            intentos++;
            if (intentos==10)
            {
                MessageBox.Show("Se ha excedido la cantidad de intentos. Cerrando la app...");
                Application.Exit();
            }
            if (msk_tb_nip.Text=="")
            {
                nipVacio = true;
            }

            if (mt_nCuenta.Text=="")
            {
                nCuenVacio = true;
            }
            if (nipVacio && nCuenVacio == true)
            {
                MessageBox.Show("Por favor ingrese sus credenciales");
            }
            else { 
            
            bool existeNip = banCosta.listUsrs.Any(item => item.Cuenta.Nip == msk_tb_nip.Text);
            bool existeCuenta = banCosta.listUsrs.Any(item => item.Cuenta.numCuenta == mt_nCuenta.Text);

                nCuenProv = mt_nCuenta.Text;

            if (existeNip && existeCuenta==true)
                                     {
                    //INICIO PREDETERMINADO


                    this.Hide();
                    Cajero cajero = new Cajero();
                    cajero.UsuarioActual = banCosta.listUsrs.Find(item => item.Cuenta.numCuenta == mt_nCuenta.Text);
                    cajero.FrmTmp = this;
                    cajero.Show();

                }
                                    else
                                    {
                                         MessageBox.Show("Sus credenciales son incorrectas, intente de nuevo");
                                         this.Show();                        
            }
            }

            //
            
        }


        // INICIO PROVISIONAL DE TODAS MIS VENTANAS

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //RegistroTemp = new Registro();
            //RegistroTemp.Show();
            //Form Cajero = new Cajero();
            //Cajero.Show();
        }

        private void lbl_adm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminCon VenAdmin = new AdminCon();
            VenAdmin.listUsrs = banCosta.listUsrs;
            VenAdmin.Show();
            Program.form1.Hide();
        }

        private void lbl_rgstr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
