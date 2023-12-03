using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMunuYSeleccion()
        {
            int opcion;

            Console.WriteLine("----------------------");
            Console.WriteLine("|0.   Cerrar Menu     |");
            Console.WriteLine("|1. Agregar cliente   |");
            Console.WriteLine("|2. Borrar cliente    |");
            Console.WriteLine("|3  Modificar cliente |");
            Console.WriteLine("|4.   Ver clientes    |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleccione una opcion");

            opcion = Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }

        public string pedirDni()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }

      
    }
}
