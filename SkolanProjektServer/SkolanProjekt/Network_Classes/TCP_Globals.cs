using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace SkolanProjekt.Network_Classes
{
    class TCP_Globals
    {
        public static Socket client;
        public static IPEndPoint IPAddrListen;
        public static TcpListener TcpListen;
        public static FrmMain frmMain;

        public static byte[] data = new byte[1024]; //TODO: get the array size on recv 
    }
}
