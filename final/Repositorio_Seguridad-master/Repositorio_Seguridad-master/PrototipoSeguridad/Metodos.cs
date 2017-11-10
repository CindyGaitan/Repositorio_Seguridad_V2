using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace PrototipoSeguridad
{
    class Metodos
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        OdbcDataReader dr;
        Conexion con = new Conexion();

        //INGRESO
        public int metodoIngreso(int aplicacion)
        {
            string ingresar; int ing = 0;
            com = new OdbcCommand("select dpd.ingresar from detalle_aplicacion_derecho dpd inner join usuario u on u.id_usuario = dpd.id_usuario where u.usuario = '"+Globales.nom_usuario+"' and id_aplicacion = "+aplicacion+" ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ingresar = dr["ingresar"].ToString();
                ing = Convert.ToInt32(ingresar);
            }

            dr.Close();
            return ing;
        }
        //MODIFICAR
        public int metodoModificar(int aplicacion)
        {
            string modificar; int modifi = 0;
            com = new OdbcCommand("select dpd.modificar from detalle_aplicacion_derecho dpd inner join usuario u on u.id_usuario = dpd.id_usuario where u.usuario = '" + Globales.nom_usuario + "' and id_aplicacion = " + aplicacion + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                modificar = dr["modificar"].ToString();
                modifi = Convert.ToInt32(modificar);
            }
            dr.Close();
            return modifi;
        }
        //ELIMINAR
        public int metodoEliminar(int aplicacion)
        {
            string eliminar; int eli = 0;
            com = new OdbcCommand("select dpd.eliminar from detalle_aplicacion_derecho dpd inner join usuario u on u.id_usuario = dpd.id_usuario where u.usuario = '" + Globales.nom_usuario + "' and id_aplicacion = " + aplicacion + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                eliminar = dr["eliminar"].ToString();
                eli = Convert.ToInt32(eliminar);
            }
            dr.Close();
            return eli;
        }
        //IMPRIMIR
        public int metodoImprimir(int aplicacion)
        {
            string imprimir; int imp = 0;
            com = new OdbcCommand("select dpd.imprimir from detalle_aplicacion_derecho dpd inner join usuario u on u.id_usuario = dpd.id_usuario where u.usuario = '" + Globales.nom_usuario + "' and id_aplicacion = " + aplicacion + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                imprimir = dr["imprimir"].ToString();
                imp = Convert.ToInt32(imprimir);
            }
            dr.Close();
            return imp;
        }
        //CONSULTAR
        public int metodoConsultar(int aplicacion)
        {
            string consultar; int cons = 0;
            com = new OdbcCommand("select dpd.consultar from detalle_aplicacion_derecho dpd inner join usuario u on u.id_usuario = dpd.id_usuario where u.usuario = '" + Globales.nom_usuario + "' and id_aplicacion = " + aplicacion + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                consultar = dr["consultar"].ToString();
                cons = Convert.ToInt32(consultar);
            }
            dr.Close();
            return cons;
        }
        public string usuario()
        {
            string n = Globales.nom_usuario;
            return n;
        }
    }
}
