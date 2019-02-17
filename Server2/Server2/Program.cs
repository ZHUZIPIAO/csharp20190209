using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;using System.IO;
namespace Server2
{
    class ClientHandler{
        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
        }
        public void chat()
        {
            stream = new NetworkStream(socket);
            Encoding encode = Encoding.GetEncoding("utf-8");
            reader = new StreamReader(stream, encode);
            writer = new StreamWriter(stream, encode)
            {
                AutoFlush = true
            };
            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);
                writer.WriteLine(str);
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다.
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();
                while (true)
                {
                    clientsocket = tcpListener.AcceptSocket();
                    ClientHandler cHandler = new ClientHandler(clientsocket);
                    Thread t = new Thread(new ThreadStart(cHandler.chat));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
