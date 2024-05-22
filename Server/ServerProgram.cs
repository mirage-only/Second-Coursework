using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Сourse_work_result;

namespace Сorse_work_result
{

    public abstract class Server
    {


        public static void Main()
        {
            /*MenuCreator creator = new MenuCreator();
            creator.CreateMenu();*/

            //JsonController.ReadMenuFromJson();
            
            Start();
        }

        private static void Start()
        {
            var orders = JsonController.ReadOrdersFromJson();
            
            var number = 0;

            if (orders.Count != 0)
            {
                number = orders[orders.Count - 1].numberOfOrder;
            }

            IPEndPoint ipPoint1 = new IPEndPoint(IPAddress.Any, 8888);
            using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint1);
            socket.Listen(100);
            Console.WriteLine("Сервер запущен. Ожидание подключений...");

            while (true)
            {
                using Socket client = socket.Accept();
                while (true)
                {
                    var buffer = new byte[7_120];
                    var received = client.Receive(buffer);
                    var response = Encoding.UTF8.GetString(buffer, 0, received);

                    List<ServerMenuItem> items = JsonConvert.DeserializeObject<List<ServerMenuItem>>(response);

                    Console.WriteLine($"Адрес подключенного клиента: {client.RemoteEndPoint}");
                    var id = items[0].ID;
                    var dataForAnswer = new List<ServerMenuItem>();

                    switch (id)
                    {
                        case 0:
                            number++;
                            
                            Order order = new Order
                            {
                                numberOfOrder = number,
                                selectedDishes = items,
                                totalCost = Order.GetCost(items)
                            };

                            orders.Add(order);
                            
                            dataForAnswer.Clear();

                            ServerMenuItem item = new ServerMenuItem
                            {
                                ID = number,
                                Name = "0",
                                Price = order.totalCost
                            };

                            dataForAnswer.Add(item);
                            client.Send(ServerController.AnswerOfMenuAndOrders(dataForAnswer));
                            break;
                        case 1:
                            dataForAnswer = JsonController.ReadMenuFromJson();
                            client.Send(ServerController.AnswerOfMenuAndOrders(dataForAnswer));
                            break;
                        case 2:
                            JsonController.SaveOrdersToJson(orders);
                            Environment.Exit(0);
                            break;
                        case 3:
                            client.Send(ServerController.AnswerHistoryOfOrders(orders));
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    
                    break;
                }
            }
        }
    }
}