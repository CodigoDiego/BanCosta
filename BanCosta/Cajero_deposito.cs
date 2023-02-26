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
    public partial class Cajero_deposito : FormTemporal
    {
        
        public List<Usuarios> listUsrs = new List<Usuarios>();
        public string nCuenProv;
        Frm_Login f1 = new Frm_Login();        
        //public List<Movimiento> historial = new List<Movimiento>();
        Cajero CajeroTmp=new Cajero();
        //Cajero_historial Cajhisttmp = new Cajero_historial();
        int transacciones = 0;
        //int saldo;
        bool boolbtn50 = false;
        bool boolbtn100 = false;
        bool boolbtn200 = false;
        bool boolbtn300 = false;
        bool boolbtn500 = false;
        bool boolbtn1000 = false;
        bool dpst = true;
        double canti = 0;
        DateTime fecha;
        public Cajero_deposito()
        {
            InitializeComponent();
            UsuarioActual = new Usuarios();
            //nCuenProv = fl.nCuenProv;
        }
        public void deposito(int cant)
        {
            //dps = UsuarioActual.Cuenta.Saldo + cant;
            //UsuarioActual.Cuenta.Saldo += cant;
            banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Saldo += cant;
        }
        public void Buscar()
        {
            int indexmod = listUsrs.FindIndex(x => x.Cuenta.numCuenta == nCuenProv);

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
        private void btn_50_Click(object sender, EventArgs e)
        {
            boolbtn100 = false;
            boolbtn200 = false;
            boolbtn300 = false;
            boolbtn500 = false;
            boolbtn1000 = false;
            boolbtn50 = true;
            lbl_cantDep.Text = "Su cantidad a depositar es: $50";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            boolbtn50 = false;
            boolbtn200 = false;
            boolbtn300 = false;
            boolbtn500 = false;
            boolbtn1000 = false;
            boolbtn100 = true;
            lbl_cantDep.Text = "Su cantidad a depositar es : $100";
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            boolbtn50 = false;
            boolbtn100 = false;
            boolbtn300 = false;
            boolbtn500 = false;
            boolbtn1000 = false;
            boolbtn200 = true;
            lbl_cantDep.Text = "Su cantidad a depositar es : $200";
        }

        private void btn_300_Click(object sender, EventArgs e)
        {
            boolbtn50 = false;
            boolbtn200 = false;
            boolbtn100 = false;
            boolbtn500 = false;
            boolbtn1000 = false;
            boolbtn300 = true;
            lbl_cantDep.Text = "Su cantidad a depositar es : $300";
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            boolbtn50 = false;
            boolbtn200 = false;
            boolbtn300 = false;
            boolbtn100 = false;
            boolbtn1000 = false;
            boolbtn500 = true;
            lbl_cantDep.Text = "Su cantidad a depositar es : $500";
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            boolbtn50 = false;
            boolbtn200 = false;
            boolbtn300 = false;
            boolbtn500 = false;
            boolbtn100 = false;
            boolbtn1000 = true; ;
            lbl_cantDep.Text = "Su cantidad a depositar es : $1000";
        }

        public void Cajero_deposito_Load(object sender, EventArgs e)
        {
            Cajero_retiro retTemp = new Cajero_retiro();
            retTemp.ActualizaClase();
        }

        public void btn_conf_Click(object sender, EventArgs e)
        {
            DateTime FechaHoy = DateTime.Now;
            
            transacciones++;
            //if (transacciones<10)
            
            if (UsuarioActual.Cuenta.Movimientos.FindAll(x => x.FechaCompleta.Year == FechaHoy.Year && x.FechaCompleta.Month == FechaHoy.Month && x.FechaCompleta.Day == FechaHoy.Day).Count < 10)
            {
                
            
            if (boolbtn50==true)
            {
                deposito(50);
                dpst = true;
                canti=50;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $50 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();

            }
            if (boolbtn100 == true)
            {
                deposito(100);
                dpst = true;
                canti = 100;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $100 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();
                }
            if (boolbtn200 == true)
            {
                deposito(200);
                dpst = true;
                canti = 200;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $200 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();

                }
            if (boolbtn300 == true)
            {
                deposito(300);
                dpst = true;
                canti = 300;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $300 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();

                }
            if (boolbtn500 == true)
            {
                deposito(500);
                dpst = true;
                canti = 500;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $500 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();

                }
            if (boolbtn1000 == true)
            {
                deposito(1000);
                dpst = true;
                canti = 1000;
                fecha = DateTime.Now;
                MessageBox.Show("Ha depositado la cantidad de $1000 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    Movimiento Historial = new Movimiento(transacciones, dpst, canti, fecha);
                    //UsuarioActual.Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historial);
                    banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                    GuardaDatosJSON();
                }
                //Cajero cajtmp = new Cajero();

                //    cajtmp.lbl_saldo.AutoSize = true;
                //cajtmp.lbl_saldo.Text = "Saldo : $"+ UsuarioActual.Cuenta.Saldo.ToString();
                //Refresh();

                //UsuarioActual.Cuenta.Movimientos.Add(Historial);
                //retTemp.ActualizaClase();
                UsuarioActual = banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta);
                FormTmp.lbl_saldo.AutoSize = true;
            FormTmp.lbl_saldo.Text = "Saldo : $" + UsuarioActual.Cuenta.Saldo.ToString();
            FormTmp.Refresh();
            Refresh();
            }
            else
            {
                MessageBox.Show("Ha llegado al limite de transacciones diarias");
            }

            f1.Actualiza_Banco();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
