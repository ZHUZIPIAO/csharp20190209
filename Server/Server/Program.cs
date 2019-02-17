using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsoket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                clientsoket = tcpListener.AcceptSocket();

                stream = new NetworkStream(clientsoket);
                Encoding encode = Encoding.GetEncoding("utf-8");
                //클라이언트가 보낸 글을읽는다
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
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsoket.Close();
            }
        }
    }
}
