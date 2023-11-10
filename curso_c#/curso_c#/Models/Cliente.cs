using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_c_.Modelos
{
    internal class Cliente
    {

        //public string Nombre
        //{  get { return nombre; } set {  nombre = value; } }

        public string id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }

        public string NombreCompleto
        { get { return Nombre + " " + Apellido; } }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}
