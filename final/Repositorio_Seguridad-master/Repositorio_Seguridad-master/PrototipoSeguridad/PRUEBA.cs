using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador.Utilidades;
using System.Collections;

namespace PrototipoSeguridad
{
    public partial class PRUEBA : Form
    {
        public int id=1;
        
        public PRUEBA()
        {
            
            InitializeComponent();          
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            navegador1.id_aplicacion = 1;
        }

        private void PRUEBA_Load(object sender, EventArgs e)
        {
            
            
        }

        private void navegador1_InsertReceive(object sender, EventArgs e)
        {
            String campo1 = textBox1.Text;
            String campo2 = textBox2.Text;
            int campo3 = Convert.ToInt32(textBox3.Text);
            int campo4 = Convert.ToInt32(textBox4.Text);
            ArrayList listavalores = new ArrayList();
            ArrayList listacampos = new ArrayList();

            listavalores.Add(campo1);
            listavalores.Add(campo2);
            listavalores.Add(campo3);
            listavalores.Add(campo4);

            listacampos.Add("nombre_aplicacion");
            listacampos.Add("descripcion_aplicacion");
            listacampos.Add("habilitar_aplicacion");
            listacampos.Add("id_reporte");

            GeneradorSQL gsql = new GeneradorSQL("server","bd","user","pass","nametabla");
            gsql.setCodigoInstDML(1);
            gsql.setCampos(listacampos);
            gsql.setValores(listavalores);
            gsql.ejecutar();
            
        }
    }
}
