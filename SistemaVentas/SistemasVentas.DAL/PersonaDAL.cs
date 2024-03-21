using SistemasGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasGestion.Modelos;

namespace SistemasGestion.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT * FROM PERSONA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            //ejecutardatatabla para conseguir las filas
            return lista;
        }
        public void InsertarPersonasDal(Persona persona )
        {
            string consulta = "INSERT INTO PERSONA VALUES('"+persona.Nombre+"',"+
                                                            "'" + persona.Apellido+"', "+                                                         
                                                            "'Activo')";
            Conexion.Ejecutar(consulta);
                                                            
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "SELECT * FROM PERSONA WHERE IDPERSONA=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
                persona.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;
        }

        public void EditarPersonaDal (Persona p)
        {
            string consulta = "UPDATE PERSONA SET nombre='" + p.Nombre + "' ," +
                                                         "apellido= '" + p.Apellido + "' ," +
                                "WHERE IDPERSONA=" + p.IdPersona;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "DELETE FROM PERSONA WHERE IDPERSONA=" + id;
            Conexion.Ejecutar (consulta);
        }
    }
}
