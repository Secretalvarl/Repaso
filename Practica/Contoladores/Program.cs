using Practica.Dtos;
using Practica.Servicios;

namespace Practica.Contoladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            menuInterfaz alpha = new menuImplementacion();
            ClienteInterfaz omega = new ClienteImplementacion();

            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                opcion = alpha.mostrarMunuYSeleccion();
                Console.WriteLine(opcion);

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] - menu cerrado");
                        cerrarMenu |= true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Agregar nuevo cliente");
                        omega.darAltaCliente(listaClientes);
                        break; 
                    case 2:
                        Console.WriteLine("[INFO] - Borrar  cliente");
                        omega.borrarCliente(listaClientes);
                        break; 
                    case 3:
                        Console.WriteLine("[INFO] - Modificar cliente");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Ver cliente");
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no coincide con ninguna");
                        break;

                    
                }
            }
        }
    }
}