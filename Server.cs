using System;
using System.Net;
using System.Net.Sockets;

namespace Chat
{
    class Server
    {
        public Server(int port)
        {
            _port = port;

            // Получаем информацию о локальном компьютере
            IPHostEntry localMachineInfo = Dns.GetHostEntry(Dns.GetHostName());
            Console.WriteLine("Host: {0}", Dns.GetHostName());

            IPEndPoint myAddress = new IPEndPoint(localMachineInfo.AddressList[0], _port);
            Console.WriteLine("Address: {0}", myAddress.Address);

            // Инициализируем серверный сокет
            _serverSocket = new Socket(myAddress.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Привязываем его к нашему адрессу
            _serverSocket.Bind(myAddress);

            // Начинаем прослушивание
            _serverSocket.Listen((int)SocketOptionName.MaxConnections);
        }

        private int _port;
        private Socket _serverSocket;
    }
}
