using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SkolanProjekt;

namespace SkolanProjekt.Network_Classes
{
    class PacketStructure
    {
        /*NOTE
         Packet structure
         [1 byte OpCode](Packet type). Get from the enumerator "OpCodes".
         [?? bytes] computer name for instance E40906 to identify the sending client.
     
         */


        public enum OpCodes : byte
        {
            WELCOME = 0x00 ,
            HEARTBEAT = 0x01 ,
            CLOSE = 0x02 ,
            WEBSITE = 0x03,
        };

        public static void manageData(byte[] incommingData)
        {
            switch (incommingData[0])
            {
                case (byte)OpCodes.HEARTBEAT :
                    TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] { OpCodes.HEARTBEAT.ToString(), CommonGlobals.Chooices.debugInfo });
                break;

                case (byte)OpCodes.WELCOME:
                    TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] { OpCodes.WELCOME.ToString(), CommonGlobals.Chooices.debugInfo });
                break;

                case (byte)OpCodes.CLOSE:
                    TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] { OpCodes.CLOSE.ToString(), CommonGlobals.Chooices.debugInfo });
                break;

                case (byte)OpCodes.WEBSITE:
                TCP_Globals.frmMain.Invoke(TCP_Globals.frmMain.passMessage, new object[] { OpCodes.WEBSITE.ToString(), CommonGlobals.Chooices.debugInfo });
                break;
            }
        }
    }
}
