using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            mf0966Entities db = new mf0966Entities();

            foreach (Cliente c in db.Clientes)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Usuario);
            }

            Cliente cliente = db.Clientes.Find(2);

            Console.WriteLine(cliente);
            Console.WriteLine(cliente.Usuario);

            Usuario adminUsuario = (from u in db.Usuarios where u.Email == "admin@email.net" select u).FirstOrDefault();
            Cliente adminCliente = new Cliente(adminUsuario.Id, "Administrador", "Administradorez", DateTime.Now, adminUsuario);

            db.Clientes.Add(adminCliente);

            db.SaveChanges();

            adminCliente.Apellidos = "Administrez";

            db.SaveChanges();

            cliente = db.Clientes.Find(9);

            Console.WriteLine(cliente);
            Console.WriteLine(cliente.Usuario);

            //cliente = new Cliente(adminUsuario.Id, "Admin", "Administradorez", DateTime.Now, adminUsuario);
            //db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

            //db.SaveChanges();

            //cliente = db.Clientes.Find(9);

            //Console.WriteLine(cliente);
            //Console.WriteLine(cliente.Usuario);

            db.Clientes.Remove(adminCliente);
            db.SaveChanges();

            foreach (Cliente c in db.Clientes)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Usuario);
            }
        }
    }
}
