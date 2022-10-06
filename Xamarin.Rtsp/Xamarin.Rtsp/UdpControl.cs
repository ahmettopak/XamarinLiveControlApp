using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Control
{
    public class UdpControl
    {
        string RobotIp = "192.168.1.3";
        string PanelIp = "192.168.1.2";
        int PanelPort = 10006;
        int RobotPort = 10006;
        Socket _socket;
        const int BufferSize = 1024;

        public const int SIO_UDP_CONNRESET = -1744830452;

        public UdpControl(string ipAddress, int portNum)
        {
            _socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            _socket.IOControl(
            (IOControlCode)SIO_UDP_CONNRESET,
            new byte[] { 0, 0, 0, 0 },
            null);
            IPAddress parsedIpAddress = IPAddress.Parse(ipAddress);
            IPEndPoint localEndPoint = new IPEndPoint(parsedIpAddress, portNum);
            _socket.Bind(localEndPoint);
        }

        public string Listen()
        {
            byte[] receivedBytes = new byte[BufferSize];
            _socket.Receive(receivedBytes);
            string hexString = Convert.ToHexString(receivedBytes);
            //string receivedMessage = Encoding.ASCII.GetString(receivedBytes);
            return hexString;
        }

        public void Send(string messageToSend, string ipAddress, int portNum)
        {
            IPAddress serverIPAddress = IPAddress.Parse(ipAddress);
            IPEndPoint serverEndPoint = new IPEndPoint(serverIPAddress, portNum);
            byte[] bytesToSend = Encoding.ASCII.GetBytes(messageToSend);
            _socket.SendTo(bytesToSend, serverEndPoint);
        }

        public string Echo()
        {
            byte[] receivedBytes = new byte[BufferSize];
            EndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            _socket.ReceiveFrom(receivedBytes, ref clientEndPoint);
            string hexString = Convert.ToHexString(receivedBytes);
            _socket.SendTo(receivedBytes, clientEndPoint);
            return hexString;
        }
    }
}