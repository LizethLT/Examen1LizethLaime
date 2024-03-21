using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasGestion.Modelos;

namespace SistemasGestion.DAL
{
    public class EmpleadoDAL
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "SELECT * FROM EMPLEADO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Empleado empleado)
        {
            string consulta = "INSERT INTO EMPLEADO VALUES (" + empleado.IdEmpleado + " , " +
                                                            " '" + empleado.IdPersona + "' , " +
                                                            " '" + empleado.Puesto + "' , " +
                                                            " '" + empleado.FechaContratacion + "')";
            Conexion.Ejecutar(consulta);
        }
    }
}
