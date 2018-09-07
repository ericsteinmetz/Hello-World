using System;
using System.Net;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient()) 
            {
                client.Headers.Add("Content-Type:application/json"); 
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:65176/api/Default");  
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
