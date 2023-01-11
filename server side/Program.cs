using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listenersocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            IPAddress ipaddr = IPAddress.Any;

            IPEndPoint ipep = new IPEndPoint(ipaddr,13);
            

            listenersocket.Bind(ipep);

            listenersocket.Listen(5);

            Console.WriteLine("About to accept incoming conection");

           Socket client = listenersocket.Accept();

            Console.WriteLine("Client connected. " + client.ToString() + " -Ip End point : " + client.RemoteEndPoint.ToString());

            byte[] buff = new byte[128];
            int numberofReceivedBytes = 0;
            while(true)
            {
                numberofReceivedBytes = client.Receive(buff);

                Console.WriteLine("Data sent by client is : " + buff);

                string receivedText = Encoding.ASCII.GetString(buff, 0, numberofReceivedBytes);

                Console.WriteLine("Data send by client is: "+receivedText);
                client.Send(buff);

                if(receivedText == "X")
                {
                    break;
                }

                Array.Clear(buff, 0, buff.Length);
                numberofReceivedBytes = 0;
            }
            



        }
    }
}
