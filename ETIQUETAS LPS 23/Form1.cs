
using ETIQUETAS_LPS_23.CLASES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ETIQUETAS_LPS_23
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=dl9xdzm83; userid=root;password=root;database=selector;");
        private int actualizar;

        public static ConexionMysql con;


        //printer obj = new printer();
        //obj.imprimir(cbo_impresoras.Text, cadena);

        public Form1()
        {
            InitializeComponent();
            cargar_empalmes();
            LBL_FECHA.Text = DateTime.Now.ToString("G");
            lista_impresoras();
            cbo_impresoras.SelectedIndex = 0;
          

        }

        // MySqlConnection miconexion = new MySqlConnection("server=dl9xdzm83; userid=root;password=root;database=selector;");

        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {

            try {
                if (txt_cantidad.Text != "")
                {
                    int x = Int32.Parse(txt_cantidad.Text);

                    for (int i = 1; i <= x; i++)
                    {
                        imprimirmasiso();
                        LBL_FECHA.Text = DateTime.Now.ToString("G");
                    }
                }
                txt_cantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        public void cargar_empalmes()
        {
            try
            {


                //indicamos la consulta en SQL
                // MySqlDataAdapter daColores = new MySqlDataAdapter("SELECT DISTINCT empalme FROM selector  ORDER BY  CAST(empalme AS UNSIGNED INTEGER)",cnLocal);

                //codigo para llenar el comboBox
                DataSet dsESTADOS = new DataSet();
                //endicamos la consulta en SQL
                MySqlDataAdapter daESTADOS = new MySqlDataAdapter("SELECT DISTINCT empalme FROM selector  ORDER BY  CAST(empalme AS UNSIGNED INTEGER) ", conexion);

                if (daESTADOS != null)
                {
                    //se indica el nombre de la tabla
                    daESTADOS.Fill(dsESTADOS, "selector");
                    CBO_EMPALME.DataSource = dsESTADOS.Tables[0].DefaultView;
                    //se especifica el campo de la tabla
                    CBO_EMPALME.ValueMember = "empalme";
                    CBO_EMPALME.DisplayMember = "empalme";
                }
                else
                {
                    // cbxNP.Enabled = false;
                    // this.btnImprimir.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
            }
        }

        private void CBO_SELECTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_opciones();
        }

        private void CBO_EMPALME_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void CBO_EMPALME_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_selectores();
        }


        public void cargar_selectores()
        {
            try
            {

                //indicamos la consulta en SQL

                //codigo para llenar el comboBox
                DataSet dsESTADOS = new DataSet();
                //endicamos la consulta en SQL
                MySqlDataAdapter daESTADOS = new MySqlDataAdapter("SELECT DISTINCT selector FROM selector where  empalme = '" + CBO_EMPALME.Text + "' ORDER BY  CAST(selector AS UNSIGNED INTEGER)", conexion);

                if (daESTADOS != null)
                {
                    //se indica el nombre de la tabla
                    daESTADOS.Fill(dsESTADOS, "selector");
                    CBO_SELECTOR.DataSource = dsESTADOS.Tables[0].DefaultView;
                    //se especifica el campo de la tabla
                    CBO_SELECTOR.ValueMember = "selector";
                    CBO_SELECTOR.DisplayMember = "selector";
                }
                else
                {
                    // cbxNP.Enabled = false;
                    // this.btnImprimir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        public void cargar_opciones()
        {
            try
            {

                //indicamos la consulta en SQL

                //codigo para llenar el comboBox
                DataSet dsESTADOS = new DataSet();
                //endicamos la consulta en SQL
                MySqlDataAdapter daESTADOS = new MySqlDataAdapter("SELECT DISTINCT opcion,INI_FIN FROM selector where selector='" + CBO_SELECTOR.Text + "' and empalme='" + CBO_EMPALME.Text + "'", conexion);

                if (daESTADOS != null)
                {
                    //se indica el nombre de la tabla
                    daESTADOS.Fill(dsESTADOS, "selector");
                    //CBO_SELECTOR.DataSource = dsESTADOS.Tables[0].DefaultView;
                    //se especifica el campo de la tabla

                    txt_opcion.Text = dsESTADOS.Tables[0].Rows[0][0].ToString();
                    txt_INIFIN.Text = dsESTADOS.Tables[0].Rows[0][1].ToString();

                }
                else
                {
                    // cbxNP.Enabled = false;
                    // this.btnImprimir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        public void imprimirmasiso()
        {
            try
            {
                if (CBO_EMPALME.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    zpl();
                }
                else
                {
                    MessageBox.Show("SELECCION EL EMPALME");
                }
            }
            catch
            {
                MessageBox.Show("NO HAY EMPALMES CARGADOS, FAVOR DE CARGARLOS");
            }
        }


        public string zpl()
        {
            string line;
            string cadena = "";

            try
            {
                // Read the file and display it line by line.  
                //System.IO.StreamReader file = new System.IO.StreamReader(@"c:\EPS\prueba.xlsx");
                System.IO.StreamReader file = new System.IO.StreamReader(@"c:\EPS\ETLPS.txt");

                while ((line = file.ReadLine()) != null)
                {
                    cadena = cadena + line;

                    //System.Console.WriteLine(line);
                }

                file.Close();
                //System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.  
                // System.Console.ReadLine();
                String exampleString = CBO_EMPALME.Text;
                String lastCharacter = exampleString.Substring(exampleString.Length - 4);

                cadena = cadena.Replace("fecha", LBL_FECHA.Text);
                cadena = cadena.Replace("empalme", CBO_EMPALME.Text);
                cadena = cadena.Replace("SELECTOR", CBO_SELECTOR.Text);
                cadena = cadena.Replace("opcion", txt_opcion.Text);
                cadena = cadena.Replace("INI_FIN", txt_INIFIN.Text);
               
                //cadena = cadena.Replace("NP", FrmPrincipal.lblNpActivo.Text);
                //cadena = cadena.Replace("master", txtSerieMaster.Text);
                //cadena = cadena.Replace("npc", txtNP.Text);
                printer obj = new printer();
                obj.imprimir(cbo_impresoras.Text, cadena);
                // obj.imprimir("ZDesigner GC420t (EPL)", cadena);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return cadena;
        }


        public void lista_impresoras()
        {
            try
            {
                if (actualizar == 1)
                {
                    cbo_impresoras.Items.Clear();
                    actualizar = 0;
                }

                if (actualizar == 0)
                {
                    foreach (String strPrinter in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    {
                        cbo_impresoras.Items.Add(strPrinter);
                    }
                    actualizar++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "No hay impresoras disponibles,"+ ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_FECHA.Text = DateTime.Now.ToString("G");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            timer1.Enabled = true;
            cargar_selectores();
        }
    }
   
}
