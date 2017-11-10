using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perfiles_usuario;
using System.Net;
using System.Data.Odbc;

namespace PrototipoSeguridad
{
    public partial class Principal : Form
    {
        Conexion con = new Conexion();
        OdbcCommand com;
        OdbcDataAdapter da;
        OdbcDataReader dr;

        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
          
            us.MdiParent = this;
            us.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles per = new Perfiles();
            per.MdiParent = this;
            per.Show(); 
        }

        private void asignacionPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsigUsuarioPerfil perU = new AsigUsuarioPerfil();
            perU.MdiParent = this;
            perU.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bt = new Bitacora();
            bt.MdiParent = this;
            bt.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicaciones2 ap = new Aplicaciones2();
            ap.MdiParent = this;
            ap.Show();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioContraseña camb = new CambioContraseña();
            camb.MdiParent = this;
            camb.Show();
        }

        private void asignacionAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoApp maplicaciones = new Frm_MantenimientoApp();
            maplicaciones.MdiParent = this;
            maplicaciones.Show();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles ap = new AsignacionaPerfiles();
            ap.MdiParent = this; ap.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection formulariosApp = Application.OpenForms;
            foreach (Form f in formulariosApp)
            {
                if (f.Name != "frmLogin")
                {
                    f.Hide();
                }
            }
            Login login = new Login();
            login.Show();
        }

        private void reportesDeBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReporte repb = new GenerarReporte();
            repb.Show();
        }
        

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GenerarReporte repb = new GenerarReporte();
            repb.Show();
        }

        private void reportesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReporteUsuario repb = new GenerarReporteUsuario();
            repb.Show();

        }

        private void reportesDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GenerarReporteAplicacion ga = new GenerarReporteAplicacion();
            //ga.Show();
        }

        private void pRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRUEBA PRUEBA = new PRUEBA();
            //PRUEBA.Show();
        }

        private void reportesDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reportesAplicacionDerechosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GenerarReporteDAD repb = new GenerarReporteDAD();
            //repb.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //GenerarReporte_DUP repb = new GenerarReporte_DUP();
            //repb.Show();
        }
    }
}
