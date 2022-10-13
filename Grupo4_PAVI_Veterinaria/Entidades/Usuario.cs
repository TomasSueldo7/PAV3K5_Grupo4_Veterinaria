using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_PAVI_Veterinaria.Entidades
{
    internal class Usuario
    {
        private string NombreUsu;
        private string Contra;
        private string Rol;
        private int Activo;
        public Usuario(string nombreUsuario, string contraseña, string rol)
        {
            NombreUsu = nombreUsuario;
            Contra = contraseña;
            Rol = rol;
        }
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Contraseña
        {
            get => Contra;
            set => Contra = value;
        }

        public string RolUsuario
        {
            get => Rol;
            set => Rol = value;
        }

        public int ActivoUsuario
        {
            get => Activo;
            set => Activo = value;
        }

        public Usuario()
        {

        }


    }
}
