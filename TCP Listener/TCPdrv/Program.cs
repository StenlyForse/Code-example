using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace TCPdrv
{
    internal class Chat
    {
        private static int localPort;
        private static IPAddress remoteIPAddress;
        private static IPAddress localIPAddress;
        private static int remotePort;
        
        public static void Receiver()
        {
            //TcpClient
           
            TcpListener server = null;
            TcpClient client = null;
            NetworkStream stream = null;
            server = new TcpListener(localIPAddress, remotePort);
            int biteAmount = 1;
            byte[] myBytes = new byte[1024];
  
            try
            {
                server.Start();
                Console.WriteLine(
                   "\n-----------*******Пересылка пакетов*******-----------");
                
                while (true)
                {
                    Console.WriteLine("Ожидание подключения");

                    client = server.AcceptTcpClient();
                    Console.WriteLine("Клиент подключен. Выполнение запроса...");

                    // получаем поток
                    stream = client.GetStream();

                    do
                    {
                        // читаем потом и получаем количество считанных байтов, данные из потока заносятся в буфер MyBytes

                        biteAmount = stream.Read(myBytes, 0, myBytes.Length);

                        // Преобразуем и отображаем данные

                        string returnData = Encoding.UTF7.GetString(myBytes, 0, biteAmount);
                        var HexResult = returnData.Select(s => string.Format("{0:X2}", ((byte)s)));
                        string StrResult = string.Empty;
                        foreach (var item in HexResult)
                        {
                            StrResult += " ";
                            StrResult += item.ToString();
                        }
                        Console.WriteLine(" --> " + StrResult.ToString());
                    }
                    while (biteAmount != 0); // после отключнения клиента из потока приходят нули
                    
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
                Console.ReadKey();
            }
            finally
            {
                //if (server != null)
                server.Stop();
            }
        }

        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                // Получаем данные, необходимые для соединения

                // локализация консоли в русский язык
                Console.OutputEncoding = Encoding.UTF7;

                Console.WriteLine("Укажите локальный порт");
                localPort = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Укажите удаленный порт");
                remotePort = Convert.ToInt32(Console.ReadLine());

               // Console.WriteLine("Укажите удаленный IP-адрес");
               // remoteIPAddress = IPAddress.Parse(Console.ReadLine());

                Console.WriteLine("Укажите локальный IP-адрес");
                localIPAddress = IPAddress.Parse(Console.ReadLine());

                // Создаем поток для прослушивания
                 Thread tRec = new Thread(new ThreadStart(Receiver));
                 tRec.Start();
               
                while (true)
                {
                    //// закрываем подключение
                    //client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
                Console.ReadKey();
            }
            finally
            {
                // Закрыть соединение
                //server.Stop();
            }
        }

        private static void Send(string datagram)
        {
            // создаем TcpClient
            TcpClient sender = new TcpClient();

            // Создаем endPoint по информации об удаленном хосте
            IPEndPoint endPoint = new IPEndPoint(remoteIPAddress, remotePort);

            try
            {
               // byte[] bytes = datagram.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => byte.Parse(i, System.Globalization.NumberStyles.HexNumber)).ToArray();
                //sender.Send(bytes, bytes.Length, endPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
            finally
            {
                // Закрыть соединение
                sender.Close();
            }
        }
    }
}