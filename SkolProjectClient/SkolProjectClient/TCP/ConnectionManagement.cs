using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace SkolProjectClient.TCP
{
    class ConnectionManagement
    {
        public IPEndPoint IpAddr;
        public Socket socket;

        //Properties vars
        #region Props
        public static bool clientConnected;
        #endregion

        ~ConnectionManagement()
        {
            socket.Send(new byte[]{(byte)Globals.opCodes.BYE});
            socket.Close();
        }

        public ConnectionManagement(IPEndPoint IPEndP)
        {
            this.IpAddr = IPEndP;
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("192.168.1.66", 3333);
        }

        #region Propterties
        public bool connectedToServer
        {
            get
            {
                return clientConnected;
            }
            private set
            {
                clientConnected = value;
            }
        }
        #endregion


    }
}
