using Practica.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            menuInterfaz buscar = new menuImplementacion();
            string DNIBuscar = buscar.pedirDni();

            ClienteDto clienteABorrar = new ClienteDto();

            foreach (ClienteDto cliente in listaAntigua) 
            {
                if (cliente.DNICliente1.Equals(DNIBuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaAntigua.Remove(clienteABorrar);
        }

        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();

            listaAntigua.Add(cliente);

        }

        private ClienteDto crearNuevoCliente()
        { 
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.ClienteId11 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca su DNI");
            nuevoCliente.DNICliente1 = Console.ReadLine();

            Console.WriteLine("Introduzca su nombre: ");
            nuevoCliente.NombreCliente1 = Console.ReadLine();

            Console.WriteLine("Introduzca sus apellidos: ");
            nuevoCliente.ApellidosCliente1 = Console.ReadLine();

            Console.WriteLine("Introduzca su fecha de nacimiento: ");
            nuevoCliente.FechanacimienoCliente1 = Console.ReadLine();

            Console.WriteLine("Introduzca su email: ");
            nuevoCliente.EmailCliente1 = Console.ReadLine();

            Console.WriteLine("Introduzca su numero de telefono: ");
            nuevoCliente.NumerotelefonoCliente1 = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;

        }
    }
}
