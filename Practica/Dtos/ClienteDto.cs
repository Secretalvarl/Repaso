using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Dtos
{
    internal class ClienteDto
    {
        public ClienteDto()
        {

        }
        long ClienteId1;

        string DNICliente;

        string NombreCliente;

        string ApellidosCliente;

        string FechanacimienoCliente;

        string EmailCliente;

        int NumerotelefonoCliente;

        public long ClienteId11 { get => this.ClienteId1; set => this.ClienteId1 = value; }
        public string DNICliente1 { get => this.DNICliente; set => this.DNICliente = value; }
        public string NombreCliente1 { get => this.NombreCliente; set => this.NombreCliente = value; }
        public string ApellidosCliente1 { get => this.ApellidosCliente; set => this.ApellidosCliente = value; }
        public string FechanacimienoCliente1 { get => this.FechanacimienoCliente; set => this.FechanacimienoCliente = value; }
        public string EmailCliente1 { get => this.EmailCliente; set => this.EmailCliente = value; }
        public int NumerotelefonoCliente1 { get => this.NumerotelefonoCliente; set => this.NumerotelefonoCliente = value; }

        public ClienteDto(long ClienteId, string DNICliente, string nombreCliente, string apellidosCliente, string fechanacimienoCliente, string emailCliente, int numerotelefonoCliente) 
        {
            this.ClienteId1 = ClienteId;
            this.DNICliente = DNICliente;
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.FechanacimienoCliente = fechanacimienoCliente;
            this.EmailCliente = emailCliente;
            this.NumerotelefonoCliente = numerotelefonoCliente;
        
        }

        public string ToString()
        {
            string clienteString = "ID: " + this.ClienteId1 +
                "DNI" + this.DNICliente +
                "Nombre" + this.NombreCliente +
                "Apellidos" + this.ApellidosCliente +
                "Fecha de Nacimiento" + this.FechanacimienoCliente +
                "Email" + this.EmailCliente +
                "Numero de telefono" + this.NumerotelefonoCliente;

            return clienteString;


        }

    }
}
