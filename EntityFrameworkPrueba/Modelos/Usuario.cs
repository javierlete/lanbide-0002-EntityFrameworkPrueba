namespace EntityFrameworkPrueba
{
    using System;
    using System.Collections.Generic;

    public partial class Usuario
    {
        public override string ToString()
        {
            return $"{Id}, {Email}, {Password}";
        }
    }
}
