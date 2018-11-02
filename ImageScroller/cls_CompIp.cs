using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScroller
{
    class cls_CompIp
    {
        string myIP;

        // Get the IP from the host name
        public String Get_ipAddress(out string MyComp_Ip)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = ip.ToString();
                    if (myIP == "")
                    {
                        MessageBox.Show("IP Address Not Found");
                    }
                }
            }
            MyComp_Ip = myIP;
            return MyComp_Ip;
        }
    }
}
