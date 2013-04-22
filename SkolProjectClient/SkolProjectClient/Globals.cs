using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkolProjectClient
{
    class Globals
    {
        public enum opCodes : byte
        {
            WELCOME = 0x00 ,
            HEARTBEAT = 0x01 ,
            BYE = 0x02 ,
            WEBSITE = 0x03 ,
        };

        public enum Browser : int
        {
            Firefox = 1,
            Opera = 2,
        }
    }
}
