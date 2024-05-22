using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Client
{
    public static class ClientController
    {
        public static  List<ClientMenuItem> GetMenuAndProcessTheOrder(List<ClientMenuItem> items)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect("127.0.0.1", 8888);
                Console.WriteLine($@"Подключение к {socket.RemoteEndPoint} установлено");

                string message = JsonConvert.SerializeObject(items);
                var messageBytes = Encoding.UTF8.GetBytes(message);
                socket.Send(messageBytes);
                
                var buffer = new byte[7_120];
                var received = socket.Receive(buffer);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                
                List<ClientMenuItem> answer = JsonConvert.DeserializeObject<List<ClientMenuItem>>(response);
                socket.Close();
                
                return answer;
            }
            catch (SocketException)
            {
                Console.WriteLine($@"Не удалось установить подключение с {socket.RemoteEndPoint}");
                return null;
            }
        }
        
        public static  void CloseClientAndSaveOrders(List<ClientMenuItem> items)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var message = JsonConvert.SerializeObject(items);
            try
            {
                socket.Connect("127.0.0.1", 8888);
                Console.WriteLine($@"Подключение к {socket.RemoteEndPoint} установлено");

                var messageBytes = Encoding.UTF8.GetBytes(message);
                socket.Send(messageBytes);
                socket.Close();
            }
            catch (SocketException)
            {
                Console.WriteLine($@"Не удалось установить подключение с {socket.RemoteEndPoint}");
            }
        }
        
        public static  List<ClientOrder> GetOrders(List<ClientMenuItem> items)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect("127.0.0.1", 8888);
                Console.WriteLine($@"Подключение к {socket.RemoteEndPoint} установлено");

                var message = JsonConvert.SerializeObject(items);
                var messageBytes = Encoding.UTF8.GetBytes(message);
                socket.Send(messageBytes);
                
                var buffer = new byte[7_120];
                var received = socket.Receive(buffer);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                
                var answer = JsonConvert.DeserializeObject<List<ClientOrder>>(response);
                socket.Close();
                
                return answer;
            }
            catch (SocketException)
            {
                Console.WriteLine($@"Не удалось установить подключение с {socket.RemoteEndPoint}");
                return null;
            }
        }
    }
}