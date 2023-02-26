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
    public partial class Cajero_retiro : FormTemporal
    {
        Banco banco = new Banco();
        Frm_Login f1 = new Frm_Login();
        Cajero Caje_tmp = new Cajero();
        Cajero_deposito Cajdeptmp = new Cajero_deposito();
        bool retbtn50 = false;
        bool retbtn100 = false;
        bool retbtn200 = false;
        bool retbtn300 = false;
        bool retbtn500 = false;
        bool retbtn1000 = false;
        int val;
        int transacciones;
        bool dpst = false;
        double canti = 0;
        DateTime fecha;
        public Cajero_retiro()
        {
            InitializeComponent();
        }
        public void ActualizaClase()
        {
            UsuarioActual = banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta);
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

        private void Cajero_retiro_Load(object sender, EventArgs e)
        {
            ActualizaClase();
        }
        public void retiro(int cantidad)
        {
            UsuarioActual.Cuenta.Saldo-=cantidad;
        }
        private void btn_ret_50_Click(object sender, EventArgs e)
        {
            retbtn50 = true;
            retbtn100 = false;
            retbtn200 = false;
            retbtn300 = false;
            retbtn500 = false;
            retbtn1000 = false;
            lbl_cantRet.Text = "Su monto a retirar es: $ 50";
            val = 50;
        }

        private void btn_ret_100_Click(object sender, EventArgs e)
        {
            retbtn50 = false;
            retbtn100 = true;
            retbtn200 = false;
            retbtn300 = false;
            retbtn500 = false;
            retbtn1000 = false;
            lbl_cantRet.Text = "Su monto a retirar es: $ 100";
            val = 100;
        }

        private void btn_ret_200_Click(object sender, EventArgs e)
        {
            retbtn50 = false;
            retbtn100 = false;
            retbtn200 = true;
            retbtn300 = false;
            retbtn500 = false;
            retbtn1000 = false;
            lbl_cantRet.Text = "Su monto a retirar es: $ 200";
            val = 200;
        }

        private void btn_ret_300_Click(object sender, EventArgs e)
        {
            retbtn50 = false;
            retbtn100 = false;
            retbtn200 = false;
            retbtn300 = true;
            retbtn500 = false;
            retbtn1000 = false;
            lbl_cantRet.Text = "Su monto a retirar es: $ 300";
            val = 300;
        }

        private void btn_ret_500_Click(object sender, EventArgs e)
        {
            retbtn50 = false;
            retbtn100 = false;
            retbtn200 = false;
            retbtn300 = false;
            retbtn500 = true;
            retbtn1000 = false;
            lbl_cantRet.Text = "Su monto a retirar es: $ 500";
            val = 500;
        }

        private void btn_ret_1000_Click(object sender, EventArgs e)
        {
            retbtn50 = false;
            retbtn100 = false;
            retbtn200 = false;
            retbtn300 = false;
            retbtn500 = false;
            retbtn1000 = true;
            lbl_cantRet.Text = "Su monto a retirar es: $ 1000";
            val = 1000;
        }

        private void lbl_cantRet_Click(object sender, EventArgs e)
        {
        }

        public void btn_ret_conf_Click(object sender, EventArgs e)
        {
            DateTime FechaHoy = DateTime.Now;
            
            if (UsuarioActual.Cuenta.Saldo>=val)
            {

                if (UsuarioActual.Cuenta.Movimientos.FindAll(x => x.FechaCompleta.Year == FechaHoy.Year && x.FechaCompleta.Month == FechaHoy.Month && x.FechaCompleta.Day == FechaHoy.Day).Count < 10)
                {



                    if (retbtn50 == true)
            {
                retiro(50);
                //saldo = dps;
                MessageBox.Show("Ha depositado la cantidad de $50 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                }
            if (retbtn100 == true)
            {
                retiro(100);
                //UsuarioActual.Cuenta.Saldo = dps;
                MessageBox.Show("Ha depositado la cantidad de $100 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                    }
            if (retbtn200 == true)
            {
                retiro(200);
                //UsuarioActual.Cuenta.Saldo = dps;
                MessageBox.Show("Ha depositado la cantidad de $200 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                    }
            if (retbtn300 == true)
            {
                retiro(300);
                //UsuarioActual.Cuenta.Saldo = dps;
                MessageBox.Show("Ha depositado la cantidad de $300 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                    }
            if (retbtn500 == true)
            {
                retiro(500);
                //UsuarioActual.Cuenta.Saldo=dps;
                MessageBox.Show("Ha depositado la cantidad de $500 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                    }
            if (retbtn1000 == true)
            {
                retiro(1000);
                //UsuarioActual.Cuenta.Saldo = dps;
                MessageBox.Show("Ha depositado la cantidad de $1000 a su cuenta" + UsuarioActual.Cuenta.Saldo);
                    dpst = false;
                    canti = val;
                    fecha = DateTime.Now;
                        Movimiento Historialret = new Movimiento(transacciones, dpst, canti, fecha);
                        UsuarioActual.Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.numCuenta == UsuarioActual.Cuenta.numCuenta).Cuenta.Movimientos.Add(Historialret);
                        banCosta.listUsrs.Find(x => x.Cuenta.Saldo == UsuarioActual.Cuenta.Saldo);
                        GuardaDatosJSON();
                    }
            }
            else
            {
                MessageBox.Show("No cuenta con el saldo suficiente para realizar el retiro");
            }
            FormTmp.lbl_saldo.AutoSize = true;
            FormTmp.lbl_saldo.Text = "Saldo : $" + UsuarioActual.Cuenta.Saldo.ToString();
            FormTmp.Refresh();
                }
            else
            {
                MessageBox.Show("Ha llegado al limite de transacciones diarias");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
