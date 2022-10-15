using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_PAVI_Veterinaria.Entidades
{
    internal class Dueño
    {
        
        private string Nombre;
        private string Apellido;
        private string Telefono;
        private int Activo;
        private int IdTipoDocumento;
        private string Documento;


        public Dueño()
        {

        }
        public Dueño(string nom, string ape, string tel)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Telefono = tel;
        }

        public string NombreDueño
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ApellidoDueño
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string TelefonoDueño
        {
            get => Telefono;
            set => Telefono = value;
        }

        public string DocumentoDueño
        {
            get => Documento;
            set => Documento = value;
        }

        public int ActivoDueño
        {
            get => Activo;
            set => Activo = value;
        }

        public int IdTipoDoc
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }
    }
}
