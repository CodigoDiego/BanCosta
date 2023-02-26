using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
//using System.Web.Script.Serialization;

namespace BanCosta
{
    public partial class Registro : Form
    {        
        public Frm_Login FrmTmp;
        //public List<Usuarios> listUsrs = new List<Usuarios>();
        int NumCuen = 2100;
        public string NCuenta;
        string RFC;
        string nacimiento = "";
        public Registro()
        {

            InitializeComponent();
        }

        public void GuardaDatosJSON()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DatosBancosta.json";
            using (StreamWriter archivo = new StreamWriter(@ruta))
            {
                /*Interprete de JSON*/
                JavaScriptSerializer jssGuarda = new JavaScriptSerializer();

                /*Opcional, delimita el tamano maximo para guardar el archivo JSON*/
                jssGuarda.MaxJsonLength = 2147483644;

                string cadenaJSON = jssGuarda.Serialize(FrmTmp.banCosta);

                /*Sobreescribe contenido del archivo*/
                archivo.WriteLine(cadenaJSON);

                archivo.Close();
            }


        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(email, expresion);
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //for (int i = 1921; i <= 2003; i++)
            //{
            //    Convert.ToString(i);
            //    cbAño.Items.Add(i);
            //}

            //Frm_Login FrmTmp = new Frm_Login();
            dtp_nacimiento.MaxDate = dtp_nacimiento.Value = DateTime.Now.AddYears(-18);
            dtp_nacimiento.MinDate = DateTime.Now.AddYears(-100);

            //string diasemana = DateTime.Now.DayOfWeek.ToString();
            //MessageBox.Show(diasemana);
            //int diaano = DateTime.Now.DayOfYear;
            //MessageBox.Show(diaano.ToString());

            //DateTime fechatest = DateTime.Now.AddHours(130);            
            //MessageBox.Show(fechatest.ToString("dd/MM/yyyy HH:mm:ss"));

            FrmTmp.Carga_Json();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
                   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void dtp_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            nacimiento = dtp_nacimiento.Value.Date.ToShortDateString();
            lbl_dtp.Text = nacimiento;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //errores de campo vacio

            //Nombres
            errorProvider1.SetError(tbNom, "");
            if (tbNom.Text == "")
            {
                errorProvider1.SetError(tbNom, "Debe ingresar un nombre");
                tbNom.Focus();
                return;
            }
            //Apellidos
            errorProvider1.SetError(tbAP, "");
            if (tbAP.Text == "")
            {
                errorProvider1.SetError(tbAP, "Debe ingresar el apellido paterno");
                tbAP.Focus();
                return;
            }

            errorProvider1.SetError(tbAM, "");
            if (tbAM.Text == "")
            {
                errorProvider1.SetError(tbAM, "Debe ingresar el apellido materno");
                tbAM.Focus();
                return;
            }

            //Sexo
            errorProvider1.SetError(cbSexo, "");
            if (cbSexo.Text == "")
            {
                errorProvider1.SetError(cbSexo, "Debe ingresar su sexo");
                cbSexo.Focus();
                return;
            }
            //Estado
            errorProvider1.SetError(cbEdo, "");
            if (cbEdo.Text == "")
            {
                errorProvider1.SetError(cbEdo, "Debe ingresar su estado de procedencia");
                cbEdo.Focus();
                return;
            }
            //Direccion
            errorProvider1.SetError(tbDir, "");
            if (tbDir.Text == "")
            {
                errorProvider1.SetError(tbDir, "Debe ingresar una dirección");
                tbDir.Focus();
                return;
            }
            //Telefono
            errorProvider1.SetError(mtTel, "");
            if (mtTel.Text == "")
            {
                errorProvider1.SetError(mtTel, "Debe ingresar un número telefónico");
                mtTel.Focus();
                return;
            }

            //Correo
            errorProvider1.SetError(mtCorr, "");
            if (mtCorr.Text == "")
            {
                errorProvider1.SetError(mtCorr, "Debe ingresar un correo");
                mtCorr.Focus();
                return;
            }







            //Asignacion de valores a la lista de la clase
            NumCuen++;
            Usuarios user = new Usuarios(tbNom.Text, tbAP.Text, tbAM.Text, cbSexo.Text, cbEdo.Text, tbDir.Text, mtTel.Text, mtCorr.Text, mt_NIP.Text, NumCuen, NCuenta, nacimiento);
            // listUsrs.Add(user);
            FrmTmp.banCosta.listUsrs.Add(user);
            string correo = mtCorr.Text;
            
            
            if (email_bien_escrito(correo))
            {

            }
            else {
                errorProvider1.SetError(mtCorr, "Ingrese una dirección válida");
                mtCorr.Focus();
                return;
            }
            //Limpieza de los campos
            tbNom.ResetText();
            tbAP.ResetText();
            tbAM.ResetText();
            cbSexo.ResetText();
            cbEdo.ResetText();
            tbDir.ResetText();
            mtTel.ResetText();
            mtCorr.ResetText();
            MessageBox.Show("Confirme que sus datos sean correctos \n " + user.Nombre + " " + user.AP + " " + user.AM + "\n" + "Sexo: " + user.Sexo + " " + "\n" + "Direccion: " + user.Dir + ", " + user.Edo + "\n" + "Numero Telefónico: " + user.Tel + "\n" + "Correo: " + user.Corr + " " + "\n" + "Se le ha generado el RFC :" + user.RFC + "\n" + "Se le asigno el siguiente numero de cuenta: " + user.Cuenta.numCuenta);


            GuardaDatosJSON();

            //this.Visible = false;
            //Program.form1.Show();
            this.Close();

            
        
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmTmp.Actualiza_Banco();
            FrmTmp.Show();
        }
    }
}
