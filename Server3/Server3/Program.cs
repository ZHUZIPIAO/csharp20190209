using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server3
{
    class Program
    {
        static List<Socket> clientSockets = new List<Socket>();


        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse
                ("127.0.0.1");

            try
            {
                TcpListener listener = new TcpListener(ip, 5001);
                listener.Start();

                while (true)
                {
                    Socket socket = listener.AcceptSocket();
                    new Thread(() => chat(socket)).Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void chat(Socket socket)
        {
            Encoding encoding = Encoding.GetEncoding("euc-kr");
            try
            {
                clientSockets.Add(socket);
                StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);
                string line;
                while ((line = readLine(reader)) != null)
                {
                    Console.WriteLine(line);
                    // ArrayList에 보관된 모든 클라이언트 처리 소켓만큼
                    // 현재 접속한 모든 클라이언트에게 글을 씀
                    foreach (Socket clientSocket in clientSockets)
                    {
                        //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다.
                        NetworkStream stream = new NetworkStream(clientSocket);
                        StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
            }
            catch
            {
            }
            finally
            {
                clientSockets.Remove(socket);
                socket.Close();
                socket = null;
            }
        }

        static string readLine(StreamReader reader)
        {
            try
            {
                return reader.ReadLine();
            }
            catch
            {
                return null;
            }
        }
    }
}
