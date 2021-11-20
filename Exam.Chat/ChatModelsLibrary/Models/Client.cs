using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatModelsLibrary.Models
{
    public class Client
    {
        public int PORT { get; set; } = 55_555;
        public string HOST { get; set; } = "127.0.0.1";
        public Socket clientSocket { get; set; }
        public string NickName { get; set; }
    }
}
