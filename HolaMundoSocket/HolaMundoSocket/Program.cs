using HolaMundoSocket.Comunicaciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Iniciando Servidor en puerto{0}", puerto);
            ServerSocket servidor = new ServerSocket(puerto);

            if (servidor.Iniciar())
            {
                //Ok puede conectar
                Console.WriteLine("Servidor Iniciado");
                while(true)
                {
                    Console.WriteLine("Esperando Cliente");
                    Socket socketCliente = servidor.ObtenerCliente();
                    //mecanismo para escribir y leerle

                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //aqui esta el protocolo de comunicacion        <CR><LF>
                    cliente.Escribir("Hola mundo cliente, dime tu nombre:");
                    string respuesta = cliente.Leer();
                    Console.WriteLine("El cliente mando a decir: {0}", respuesta);
                    cliente.Escribir("Hasta la vista bey be" + respuesta);
                    cliente.Desconectar();
                }
            }
            else
            {
                Console.WriteLine("Error, el puerto {0} esta en uso...", puerto);
            }
        }
    }
}
