using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Server
{
    class Program
    {
        static List<Socket> Clients = new List<Socket>();
        static void Main(string[] args)
        {
            Console.Title = "CHAT.SERVER";
            const int PORT = 55_555;
            const string HOST = "127.0.0.1";

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(HOST), PORT);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                serverSocket.Bind(endPoint);
                serverSocket.Listen(10);

                Console.WriteLine("Up successfully...");
                Console.WriteLine("Pending...");

                while(true)
                {
                    Socket socket = serverSocket.Accept();
                    Console.WriteLine($"Client has been connected - {socket.RemoteEndPoint}");
                    Clients.Add(socket);

                    ListenConnectedSocket(socket);
                    
                }
            }
            catch(SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListenConnectedSocket(Socket socket)
        {
            Task.Run(() =>
            {
                Console.WriteLine($"Listening for the socket - {socket.RemoteEndPoint}");
                while(true)
                {
                    byte[] msgBuff = ReceiveMessage(socket);
                    string message = AdapterBytesToString(msgBuff);

                    Console.WriteLine($"Server, receive message - {message}");

                    Broadcast(msgBuff);
                }
            });
        }

        static byte[] ReceiveMessage(Socket socket)
        {
            const int BUFF_SIZE = 255;
            byte[] buffer = new byte[BUFF_SIZE];
            socket.Receive(buffer);
            return buffer;
        }

        static void Broadcast(byte[] data)
        {
            Clients.ForEach(c =>
            {
                if (c.Connected)
                {
                    c.Send(data);
                }
            });
        }

        static void Unicast(byte[] data)
        {

        }

        static string AdapterBytesToString(byte[] data)
        {
            return Encoding.UTF8.GetString(data, 0, data.Length);
        }
    }
}
