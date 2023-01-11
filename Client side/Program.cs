using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client_side
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket client = null;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddr = null;

            try
            {
                Console.WriteLine("Welcome to Socket client starter");
                Console.WriteLine("Please enter a valid ip address and press enter");

                string strIPAddress = Console.ReadLine();

                Console.WriteLine("Please supply a valid port number 0-65535 and press enter");
                String srtPortInput = Console.ReadLine();
                int nPortInput = 0;

               if(!IPAddress.TryParse(strIPAddress, out ipaddr))
               {
                    Console.WriteLine("Invalid server Ip supplied");
               }
                if(!int.TryParse(srtPortInput.Trim(), out nPortInput))
               {
                    Console.WriteLine("Invalid port number supplied");
               }
                client.Connect(ipaddr,nPortInput);

                Console.WriteLine("Connected to the server, type text and press enter to sent it to server,type <Exit> to close.");

                string inputCommand = string.Empty;

                while(true)
                {
                    inputCommand = Console.ReadLine();
                    if(inputCommand.Equals("<EXIT>"))
                    {
                        break;
                    }

                   byte[] buffsend = Encoding.ASCII.GetBytes(inputCommand);

                    client.Send(buffsend);

                    byte[] buffReceived = new byte[128];
                    int nRecv = client.Receive(buffReceived);

             
                }
                   
            }

            catch (Exception excp)
            {
                Console.WriteLine(excp.ToString());
            }

            finally
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client.Dispose();
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadLine();
        }
    }
}
