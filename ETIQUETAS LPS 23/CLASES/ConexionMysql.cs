using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETIQUETAS_LPS_23.CLASES
{
   public class ConexionMysql
    {
      
        public MySqlConnection conexion;
        private string pathCE = "server=dl9xdzm83; userid=root;password=root;database=selector;";

        public ConexionMysql()
        {
            conectarmasiso();
        }

        public void conectarmasiso()
        {
            try
            {
                StreamReader file = new StreamReader("C:\\EPS\\conexionET.xxx");
                string instancia = file.ReadLine();
                string BD = file.ReadLine();
                string usuario = file.ReadLine();
                string pass = file.ReadLine();
                this.pathCE = string.Concat(new string[]
                {
                    "Server=",
                    instancia,
                    ";Database=",
                    BD,
                    ";User Id=",
                    usuario,
                    "; Password=",
                    pass
                });
                file.Close();
                this.conexion = new MySqlConnection();
                this.conexion.ConnectionString = this.pathCE;
                this.abrir();
                Console.WriteLine("Connection Successful");
            }
            catch (Exception e)
            {
                //FrmPrincipal.log.agregarLinea(e.ToString());
                Console.WriteLine(e.Message);
            }
        }

        public void abrir()
        {
            try
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
                this.conexion.Open();
                Console.WriteLine("Connection Successful");
            }
            catch (Exception e)
            {
                //FrmPrincipal.log.agregarLinea(e.ToString());
                Console.WriteLine(e.Message+"abrir");
            }
        }

       


    }
}
