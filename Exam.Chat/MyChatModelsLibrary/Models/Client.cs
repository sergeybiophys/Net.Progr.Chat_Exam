using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyChatModelsLibrary.Models
{
    public class Client
    {
        const int PORT  = 55_555;
        const string HOST  = "127.0.0.1";
        public Socket clientSocket { get; set; }
        public string NickName { get; set; } = "Mr.Robot";
        public IPEndPoint iPEndPoint { get; set; }

        public Client() 
        {
            this.clientSocket = new Socket(AddressFamily.InterNetwork,
                                                    SocketType.Stream,
                                                    ProtocolType.Tcp);
            this.iPEndPoint = new IPEndPoint(IPAddress.Parse(HOST), PORT);
        }
        public Client(string nickname)
        {
            this.NickName = nickname;

            this.clientSocket = new Socket(AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);
            this.iPEndPoint = new IPEndPoint(IPAddress.Parse(HOST), PORT);
        }
    }
}
