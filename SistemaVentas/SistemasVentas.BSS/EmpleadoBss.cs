using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasGestion.DAL;
using SistemasGestion.Modelos;

namespace SistemasVentas.BSS
{
    public class EmpleadoBss

    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
    }
}
