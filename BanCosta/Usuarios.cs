using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanCosta
{

    public class Usuarios
    {       
        public string Nombre { get;  set; }
        public string AP { get; set; }
        public string AM { get; set; }
        public string Sexo { get; set; }
        public string Edo { get; set; }
        public string Dir { get; set; }
        public string Tel { get; set; }
        public string Corr { get; set; }
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public int NumCuen { get; set; }
        public string Nacimiento { get; set; }
        public string Nip { get; set; }
        public string NCuenta { get; set; }

        /*Quitar numCuenta de propiedades*/
        //public string numCuenta { get; set; }
        /**/
        public Cuenta Cuenta { get; set; }
        public string RFC { get; set; }

        public Usuarios()
        {
            Nombre = "";
            AP = "";
            AM = "";
            Sexo = "";
            Edo = "";
            Dir = "";
            Tel = "";
            Corr = "";
            Dia = "";
            Mes = "";
            Año = "";
            Nacimiento = "";
            NumCuen = 0;

            Cuenta = new Cuenta();
      }
        public class Transacciones
        {
            int Transaccion;
        }

       
        public Usuarios(string nombre, string aP, string aM, string sexo, string edo, string dir, string tel, string corr, string nip, int numCuen, string nCuenta, string nacimiento)
        {

            Nombre = nombre;
            AP = aP;
            AM = aM;
            Sexo = sexo;
            Edo = edo;
            Dir = dir;
            Tel = tel;
            Corr = corr;
            Nip = nip;
            Nacimiento = nacimiento;
            NumCuen = numCuen;
            string APrfc = AP.Substring(0, 2);
            string AMrfc = AM.Substring(0, 1);
            string Nom_rfc = Nombre.Substring(0, 1);
            string Año_rfc = Nacimiento.Substring(8, 2);
            string Mes_rfc = Nacimiento.Substring(3, 2);
            string Dia_rfc = Nacimiento.Substring(0, 2);
            //Nip = nip;






            //OBTENCION DE RFC


            RFC = APrfc + AMrfc + Nom_rfc + Año_rfc + Mes_rfc + Dia_rfc;
            NCuenta =Año_rfc+ Mes_rfc + Dia_rfc + NumCuen.ToString();
            //NCuenta = nCuenta;
            Cuenta = new Cuenta(NCuenta, nip);
            
        }   
        public string Obtiene_Nombre()
        {
            return AP + " " + AM + " " + Nombre;
        }
    }
    public class Cuenta 
    {
        public string numCuenta { get; set; }
        public string Nip { get; set; }
        public double Saldo { get; set; }      
        public List<Movimiento> Movimientos { get; set; }

        public Cuenta()
        {
            numCuenta = "";
            Nip = "";
            Saldo = 0;
            Movimientos = new List<Movimiento>();
        }

        public Cuenta(string numCuenta, string nip, double Saldo = 0)
        {            
            this.numCuenta = numCuenta; // Duda
            Nip = nip;
            this.Saldo = Saldo;

            Movimientos = new List<Movimiento>();
            //Movimientos.OrderByDescending(x => x.Fecha).Reverse();
            Movimientos.OrderByDescending(x => x.fecha);
        }
    }
    public class Movimiento
    {
        public bool tipo { get; set; }
        public double cantidad { get; set; }
        public string fecha { get; set; }
        public DateTime FechaCompleta { get; set; }
        public string tip0 { get; set; }
        public int Transacciones { get; set; }
        public Source Source { get; set; }


        public Movimiento()
        {
            tipo = false;
            cantidad = 0;
            fecha = "";
            tip0 = "";
            Source = new Source();

        }
        public Movimiento(int transacciones, bool dpst, double canti,DateTime f3cha)
        {
            Transacciones = transacciones;
            tipo = dpst;
            cantidad = canti;
            fecha = f3cha.ToLongTimeString();
            FechaCompleta = f3cha;
            if (tipo == true)
            {
                tip0 = "Deposito";
            }
            else
            {
                tip0 = "Retiro";
            }

            Source = new Source(tip0, FechaCompleta, canti);
        }
    }
        public class Source
        {
            public string Tipo { get; set; }
            public DateTime FechaCompleta { get; set; }
            public double Cantidad { get; set; }


            public Source()
            {
                Tipo = "";
                FechaCompleta = DateTime.Now;
                Cantidad = 0;
            }


            public Source(string tipo, DateTime FechaCompleta, double canti)
            {
                this.Tipo = tipo;
                this.FechaCompleta = FechaCompleta;
                this.Cantidad = canti;

            }
        }
}
