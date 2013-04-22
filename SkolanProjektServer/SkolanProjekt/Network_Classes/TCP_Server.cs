using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace SkolanProjekt.Network_Classes
{
    class TCP_Server
    {
        public TCP_Server(IPEndPoint Ip_Addr, FrmMain Frmmain) //Constructor #1
        {

            //Init Main frm
            TCP_Globals.frmMain = Frmmain;

            //Init network variables
            #region Network Init
            TCP_Globals.IPAddrListen = Ip_Addr;
            TCP_Globals.TcpListen = new TcpListener(TCP_Globals.IPAddrListen);
            #endregion

            //Start listen
            StartListen();

        }

        private void StartListen()
        {
            TCP_Globals.TcpListen.Start(0);
            TCP_Globals.TcpListen.BeginAcceptTcpClient(new AsyncCallback(IncommingClients), null);
            TCP_Globals.frmMain.DebugListBox.Items.Add("[+]: Listening");
        }

        //Asynchronous methods
        private void IncommingClients(IAsyncResult ar)
        {
            TCP_Globals.client = TCP_Globals.TcpListen.EndAcceptSocket(ar);

            #region Handle the new connection
            TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] {"[+] Accepted connection", CommonGlobals.Chooices.debugInfo});
            TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] {TCP_Globals.client.RemoteEndPoint.AddressFamily.ToString(), CommonGlobals.Chooices.addClient });
            CommonGlobals.clientList.Add(TCP_Globals.client.RemoteEndPoint.AddressFamily.ToString());
            #endregion //Client management

            SocketError error; //Save error if any occur on connection

            TCP_Globals.client.BeginReceive(TCP_Globals.data, 0, 1024, SocketFlags.None, out error,
                new AsyncCallback(ReadData), TCP_Globals.client);

            TCP_Globals.TcpListen.BeginAcceptTcpClient(new AsyncCallback(IncommingClients), null);
        }

        private void ReadData(IAsyncResult ar)
        {
            SocketError error;
            int BytesRecv = TCP_Globals.client.EndReceive(ar, out error);
            string dataRecv = Encoding.ASCII.GetString(TCP_Globals.data, 0, BytesRecv);
            PacketStructure.manageData(TCP_Globals.data);
            //TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] { "[+, Incomming]: " + dataRecv, CommonGlobals.Chooices.debugInfo});
            Array.Clear(TCP_Globals.data, 0, BytesRecv);

            TCP_Globals.client.BeginReceive(TCP_Globals.data, 0, 1024, SocketFlags.None, out error,
    new AsyncCallback(ReadData), null);
        }
    }
}
