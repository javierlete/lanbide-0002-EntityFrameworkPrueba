using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPrueba
{
    using System;
    using System.Collections.Generic;

    public partial class Cliente
    {
        public Cliente() { }
        public Cliente(long id, string nombre, string apellidos, DateTime? fechaNacimiento, Usuario usuario)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Usuario = usuario;
        }

        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Apellidos}, {FechaNacimiento}";
        }
    }
}
