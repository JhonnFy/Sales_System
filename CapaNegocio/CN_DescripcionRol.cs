using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_DescripcionRol
    {
        //Instanciar Rol
        private CD_Rol obj_rol = new CD_Rol();

        //Metodo Para Obtener Un Solo Rol
        public List<Rol>Listar(int IdRol)
        {
            return obj_rol.Listar(IdRol);
        }

        //Metodo Para Obtener Todos Los Roles
        public List<Rol> ListarTodos()
        {
            return obj_rol.ListarTodos();
        }

    }
}
