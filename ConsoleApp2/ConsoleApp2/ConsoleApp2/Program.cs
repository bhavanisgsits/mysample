using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = "{ \"CorrelationID\": \"hello\" , \"LogDateTime\": \"2021-11-02\" , \"LogKey\": \"Func Name being called\" , \"LogType\": \"Information\" , \"LogValue\": \"Function Pathfinder being called\" , \"ParentCorrelationID\", \"hello\"  }";

            byte[] postBytes = Encoding.UTF8.GetBytes(json);
            //HttpRequestMessage msg = new HttpRequestMessage();
             //var content = new FormUrlEncodedContent(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            //HttpClient client = new HttpClient();
            //var response =  client.PostAsync("https://loggingfuncapp.azurewebsites.net/api/CustomLogHTTPClient?code=FbUa04KCkp52YM0NfvMSzxleC08lkVa3jsz4ezRHgJ/9q94KyX10CQ==", content);

            //var responseString = response.Result.Content.ReadAsStringAsync().Result;
            //Console.WriteLine("Response --->"+responseString);


            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://loggingfuncapp.azurewebsites.net/api/CustomLogHTTPClient?code=FbUa04KCkp52YM0NfvMSzxleC08lkVa3jsz4ezRHgJ/9q94KyX10CQ=="));

            request.Content = content;
            var response =  httpClient.SendAsync(request);
            string responseString = response.Result.Content.ToString();
            Console.WriteLine(responseString);



        }
    }
}
