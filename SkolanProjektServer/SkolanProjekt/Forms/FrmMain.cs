using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Threading;
using System.Net;
using System.Net.Sockets;

using SkolanProjekt.Network_Classes;

namespace SkolanProjekt
{
    public partial class FrmMain : Form
    {
        public delegate void DelegatePassMessages(string debugInfo, CommonGlobals.Chooices chooice);
        public DelegatePassMessages passMessage;

        public FrmMain()
        {
            InitializeComponent();
            passMessage = new DelegatePassMessages(this.AddListItemMethod);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TCP_Server srv_list = new TCP_Server(new IPEndPoint(IPAddress.Any, 3333), this);
        }

        public void AddListItemMethod(string debugInfo, CommonGlobals.Chooices chooice)
        {
            switch(chooice)
            {
                case CommonGlobals.Chooices.debugInfo:
                    DebugListBox.Items.Add(debugInfo);
                    DebugListBox.Update();
                break;

                case CommonGlobals.Chooices.addClient:
                    ConnectedPCS.Items.Add(debugInfo);
                break;
            }
        }



    }
}
