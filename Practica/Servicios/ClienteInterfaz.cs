using Practica.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal interface ClienteInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);

        public void borrarCliente(List<ClienteDto> listaAntigua);

    }
}
