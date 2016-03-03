using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCrackingServer
{
    class Program
    {
        public const Int32 Port = 13000;
        static void Main(string[] args)
        {
            Server server = new Server(Port);
            server.Start();
        }
    }
}
