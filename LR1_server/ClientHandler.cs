using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LR1_server
{
    class ClientHandler
    {
        public TcpClient clientSocket;
        public void RunClient()
        {
            StreamReader readerStream = new StreamReader(clientSocket.GetStream());
            NetworkStream writerStream = clientSocket.GetStream();

            string returnData = readerStream.ReadLine();
            string name = returnData;
            Console.WriteLine("Welcome " + name + "to the server");

            //1
            string msg = @"HTTP/1.1 200 OK
                        Server: Apache
                        Content-Type: text/html; charset=utf-8

                        <!DOCTYPE html>
                        <html>
                        <body>
                        <h1>My First Heading</h1>
                        <p>My first paragraph.</p>
                        </body>
                        </html>" + Environment.NewLine;

            byte[] sus = Encoding.UTF8.GetBytes(msg);
            writerStream.Write(sus, 0, sus.Length);
            //1

            //while (true)
            //{
            //    returnData = readerStream.ReadLine();
            //    if (returnData.IndexOf("QUIT") > -1)
            //    {
            //        Console.WriteLine("Goodbye " + name);
            //        break;
            //    }
            //    Console.WriteLine(name + " : " + returnData);
            //    returnData += "\r\n";

            //    byte[] dataWrite = Encoding.ASCII.GetBytes(returnData);
            //    writerStream.Write(dataWrite, 0, dataWrite.Length);
            //}

            //clientSocket.Close();







        }

    }
}
