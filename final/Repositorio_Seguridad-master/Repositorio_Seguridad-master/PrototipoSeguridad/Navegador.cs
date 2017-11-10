using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador.Utilidades;
using PrototipoSeguridad.Properties;
using dll_bitacora;
using System.Data.Odbc;
using System.Net;
using PrototipoSeguridad.Properties;



namespace Navegador
{
    public partial class Navegador : UserControl
    {
        [Description("Direccion servidor")]
        [Category("ParametrosBD")]
        public String servidor{ get; set; }
        [Description("BaseDatos")]
        [Category("ParametrosBD")]
        public String nombreBD { get; set; }
        [Description("NombreTabla")]
        [Category("ParametrosBD")]
        public String nombreTabla { get; set; }
        [Description("Usuario")]
        [Category("ParametrosBD")]
        public String usuario { get; set; }
        [Description("Contraseña")]
        [Category("ParametrosBD")]
        public String pass { get; set; }
        private Conector con;
        public int iPosicion = 0,iFilastotal;
        [Category("IDaplicacion")]
        public int id_aplicacion { get; set; }
        [Category("IDusuario")]
        public static string id_usuario { get; set; }


        OdbcCommand com;
        public static String s_error;
        private string localIP;
        private string error_nuevo;

        public static String stringpad = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";
        bitacora_dll.bitacora_dll connection = new bitacora_dll.bitacora_dll(stringpad);

        public void obtenerIP()
        {
            IPHostEntry host;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
        }

        public Navegador()
        {
            InitializeComponent();
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;

            btn_guardar.Enabled = false;
            btn_adelante.Enabled = false;
            btn_primero.Enabled = false;
            btn_atras.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_imprimir.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrototipoSeguridad.PRUEBA p = new PrototipoSeguridad.PRUEBA();
            //int id_aplicacion = p.id;
            PrototipoSeguridad.Metodos m = new PrototipoSeguridad.Metodos();
            int var1, var2, var3, var4, var5;
            var1 = m.metodoIngreso(id_aplicacion);
            var2 = m.metodoModificar(id_aplicacion);
            var3 = m.metodoEliminar(id_aplicacion);
            var4 = m.metodoImprimir(id_aplicacion);
            var5 = m.metodoConsultar(id_aplicacion);
            if (var1 == 1) //INGRESO
            { btn_guardar.Enabled = true; }
            else { btn_guardar.Enabled = false; }
            if (var2 == 1) // MODIFICAR
            { btn_modificar.Enabled = true; }
            else { btn_modificar.Enabled = false; }
            if (var3 == 1) //ELIMINAR
            { btn_eliminar.Enabled = true; }
            else { btn_eliminar.Enabled = false; }
            if (var4 == 1) //IMPRIMIR
            { btn_imprimir.Enabled = true; }
            else { btn_imprimir.Enabled = false; }
            if (var5 == 1)//CONSULTAR
            { button5.Enabled = true; }
            else { button5.Enabled = false; }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.InsertReceive != null)
                this.InsertReceive(this, e);

        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public event EventHandler InsertReceive;
        public event EventHandler UpdateReceive;
        public event EventHandler DeleteReceive;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.UpdateReceive != null)
                this.UpdateReceive(this, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.DeleteReceive != null)
                this.DeleteReceive(this, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (iPosicion == 0)
            {
                iPosicion = 0;
            }
            else if (iPosicion > 0)
            {
                iPosicion--;
            }
            getDatoManipulable(iPosicion);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iPosicion = 0;
            getDatoManipulable(iPosicion);
        }

        public string getDatoManipulable(int posicion) {
            String resultado = "";
            con = new Conector(servidor,nombreBD,usuario,pass);
            con.OpenConnection();
            DataTable res = con.informacion("Select * FROM users");
            DataSet data = new DataSet("NAV");
            data.Tables.Add(res);
            resultado = data.Tables[0].Rows[iPosicion][1].ToString();
            MessageBox.Show("Dato : " + resultado);
            return resultado;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            iPosicion++;
            getDatoManipulable(iPosicion);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = Convert.ToString(id_aplicacion);
            try
            {
                if (this.InsertReceive != null)
                    this.InsertReceive(this, e);

                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='"+ id_usuario +" '), sysdate(), now(), 'Guardar', '" + app + "','Exitoso', 'No','" + localIP + "')");
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                s_error = "." + ex.Message + ".";
                String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string i in A)
                {
                    error_nuevo += i;
                }
                connection.OpenConnection();
                connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + id_usuario + "'), sysdate(), now(), 'Guardar', '" + app + "','No exitoso', '" + error_nuevo + "','" + localIP + "')");
                connection.CloseConnection();
                MessageBox.Show("Se ha Ingresado Incorrectamente!");
            }          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_adelante.Enabled = true;
            btn_primero.Enabled = true;
            btn_atras.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_imprimir.Enabled = true;
            btn_modificar.Enabled = true;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            iPosicion = iFilastotal - 1;
            getDatoManipulable(iPosicion);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
