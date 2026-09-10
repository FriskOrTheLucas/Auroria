using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace Auroria.NT
{
    public static class CheckPorts
    {
        public static bool IsTcpPortInUse(int port)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            // Get all active TCP listeners
            IPEndPoint[] TcpListeners = ipProperties.GetActiveTcpListeners();

            return TcpListeners.Any(endPoint => endPoint.Port == port);
        }
    }
}
