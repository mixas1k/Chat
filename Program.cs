using System;
using System.Net.Sockets;

namespace Chat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Server server = new Server(2200);

            Console.ReadLine();
        }
    }
}
