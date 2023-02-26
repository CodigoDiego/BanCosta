using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Web.Script.Serialization;

namespace BanCosta
{
    public partial class Edit : FormTemporal
    {
        //public Banco banCosta = new Banco();
        Frm_Login f1 = new Frm_Login();
        public int numcuen;
        public string nip;
        string ncuen;
        string nacimiento;
        public List<Usuarios> listUsrs = new List<Usuarios>();
        Registro Rt = new Registro();
        //public Usuarios UsuarioActual = new Usuarios();
        public Edit()
        {
            InitializeComponent();
            UsuarioActual = new Usuarios();
            
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

                string cadenaJSON = jssGuarda.Serialize(banCosta);

                /*Sobreescribe contenido del archivo*/
                archivo.WriteLine(cadenaJSON);

                archivo.Close();
            }
        }

            public void LimpiarCampos()
        {
            cb_usrs.Text = "";
            tbNom_edit.Text = "";
            tbAP_edit.Text = "";
            tbAM_edit.Text = "";
            cbSexo_edit.Text = "";
            cbEdo_edit.Text = "";
            tbDir_edit.Text = "";
            mtTel_edit.Text = "";
            mtCorr_edit.Text = "";
            dtp_nacimiento_edit.Text = "";
            nip = "";
            nacimiento = "";
            ncuen = "";

        }
        public void AñadeUsuario()
        {
            foreach (Usuarios usuario in listUsrs.OrderBy(x => x.AP))
                cb_usrs.Items.Add(usuario.Obtiene_Nombre() + " (" + usuario.Cuenta.numCuenta.ToString() + ")");
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            f1.Carga_Json();
            //UsuarioActual = banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta);
            //cb_usrs.DataSource = listUsrs;
            //cb_usrs.DataSource = UsuarioActual.Nombre;
            cb_usrs.Items.Clear();

            AñadeUsuario();
        }
        private void btn_srch_Click(object sender, EventArgs e)
        {
            if (!ValidarNC()) return;
        }

        private bool ValidarNC()
        {
                if(cb_usrs.Text=="")
                    {
                    errorProvider1.SetError(cb_usrs, "Debe Ingresar un ID de la persona");
                cb_usrs.Focus();
                    return false;
                    }
               errorProvider1.SetError(cb_usrs, "");
            return true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.form1.Show();
        }

        public void cb_usrs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_usrs.SelectedItem.ToString().Length > 0)
            {
                //Propiedad SPLIT que parte la cadena en el punto en el que se le indique (en este caso en un paréntesis)
                string[] splt1 = cb_usrs.SelectedItem.ToString().Split(new char[] { '(' });
                //Se toma la primer cadena con la parte que nos interesa (0 o 1) y se vuelve a partir hasta donde nos interese
                string[] split2 = splt1[1].Split(new char[] { ')' });
                //una vez partida, guardamos la parte que nos interese en una variable
                string cuentaseleccionada = split2[0];

                //se busca dentro de la lista de usuarios un atributo que coincida con la cadena obtenida
                Usuarios usuarioseleccionado = listUsrs.Find(x => x.Cuenta.numCuenta == cuentaseleccionada);

                //se cargan los datos del usuario que se seleccionó en los respectivos campos
                tbNom_edit.Text = usuarioseleccionado.Nombre;
                tbAP_edit.Text = usuarioseleccionado.AP;
                tbAM_edit.Text = usuarioseleccionado.AM;
                cbSexo_edit.Text = usuarioseleccionado.Sexo;
                cbEdo_edit.Text = usuarioseleccionado.Edo;
                tbDir_edit.Text = usuarioseleccionado.Dir;
                mtTel_edit.Text = usuarioseleccionado.Tel;
                mtCorr_edit.Text = usuarioseleccionado.Corr;
                dtp_nacimiento_edit.Text = usuarioseleccionado.Nacimiento;
                numcuen = usuarioseleccionado.NumCuen;
                nip = usuarioseleccionado.Nip;
                nacimiento = usuarioseleccionado.Nacimiento;
                ncuen = usuarioseleccionado.NCuenta;

            }
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            ///*Metodo 1*/
            //listUsrs.RemoveAll(x => x.Cuenta.numCuenta == ncuen);
            //Usuarios user = new Usuarios(tbNom_edit.Text, tbAP_edit.Text, tbAM_edit.Text, cbSexo_edit.Text, cbEdo_edit.Text, tbDir_edit.Text, mtTel_edit.Text, mtCorr_edit.Text,nip,numcuen,ncuen,nacimiento);
            //listUsrs.Add(user);

            ///*Metodo 2*/
            //Usuarios usuariomod = listUsrs.Find(x => x.Cuenta.numCuenta == ncuen);
            //usuariomod = new Usuarios(tbNom_edit.Text, tbAP_edit.Text, tbAM_edit.Text, cbSexo_edit.Text, cbEdo_edit.Text, tbDir_edit.Text, mtTel_edit.Text, mtCorr_edit.Text, nip, numcuen, ncuen, nacimiento);

            /*Metodo 3*/
            int indexmod = listUsrs.FindIndex(x => x.Cuenta.numCuenta == ncuen);
            listUsrs[indexmod] = new Usuarios(tbNom_edit.Text, tbAP_edit.Text, tbAM_edit.Text, cbSexo_edit.Text, cbEdo_edit.Text, tbDir_edit.Text, mtTel_edit.Text, mtCorr_edit.Text, nip, numcuen, ncuen, nacimiento);
            banCosta.listUsrs = listUsrs;

            cb_usrs.Items.Clear();
            AñadeUsuario();
            GuardaDatosJSON();
            LimpiarCampos();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] splt1 = cb_usrs.SelectedItem.ToString().Split(new char[] { '(' });

            string[] split2 = splt1[1].Split(new char[] { ')' });

            string cuentaseleccionada = split2[0];
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar al usuario seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                banCosta.listUsrs = listUsrs;
                Usuarios usuarioseleccionado = banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == cuentaseleccionada);
            foreach (Usuarios usuario  in listUsrs)
            {

            if (cuentaseleccionada==usuarioseleccionado.Cuenta.numCuenta)
            {
                listUsrs.Remove(usuario);
                        banCosta.listUsrs = listUsrs;
                        cb_usrs.Items.Clear();
            GuardaDatosJSON();


                        //Limpiar Campos


                        break;
            }
                    else
                    {
                        MessageBox.Show("El usuario no se ha encontrado");
                    }
                AñadeUsuario();
                    GuardaDatosJSON();
                    LimpiarCampos();
            }

            }

            else

            { 
            
            }
        }
        //private bool ValidarNC()
        //{
        //    if(tb_busqueda.Text=="")
        //        {
        //        errorProvider1.SetError(tb_busqueda, "Debe Ingresar un ID de la persona");
        //        tb_busqueda.Focus();
        //        return false;
        //        }
        //    errorProvider1.SetError(tb_busqueda, "");
        //}

    }
}
