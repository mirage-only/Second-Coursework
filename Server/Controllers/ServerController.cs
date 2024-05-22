using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Сourse_work_result;

namespace Сorse_work_result;

public static class ServerController
{
    public static byte[] AnswerOfMenuAndOrders(List<ServerMenuItem> dataForAnswer)
    {
        var answer = JsonConvert.SerializeObject(dataForAnswer);

        var messageBytes = Encoding.UTF8.GetBytes(answer);  
        
        return messageBytes;
    }
    
    public static byte[] AnswerHistoryOfOrders(List<Order> dataForAnswer)
    {
        var answer = JsonConvert.SerializeObject(dataForAnswer);

        var messageBytes = Encoding.UTF8.GetBytes(answer);  
        
        return messageBytes;
    }
}