using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    public delegate void TransmitData(byte[] data); // Fixed missing semicolon  

    public delegate void TransmitEventHandler(object sender, TransimitEventAgrs s);
    public class TransimitEventAgrs : EventArgs // Fixed colon to match proper syntax  
    {
        SerialPort sp { get; set; }
        public byte[] data { get; set; }

    }
}
