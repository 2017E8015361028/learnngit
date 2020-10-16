using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using Word = Microsoft.Office.Interop.Word;

namespace ConsoleApp1
{
    class Program
    {
        class RedisUtils
        {
            public RedisClient redis_client;
            public RedisUtils(string host, int queueport, string password)
            {
                // Console.WriteLine($"Host:{config.redis_host},Port:{config.redis_port_queue},Password:{config.redis_pass}");
                //redis_client = new RedisClient("h.redis.sogou", 2335, "sogoufanyiapp2020");
                redis_client = new RedisClient(host, queueport, password);
            }
            static void Main(string[] args)
            {
                string redis_server = "h.redis.sogou";
                string redis_port = "2335";
                string redis_password = "sogoufanyiapp2020";
                RedisUtils redis = new RedisUtils(redis_server, int.Parse(redis_port), redis_password);
                Console.WriteLine("111111111111111111111111111111111111111");
                Console.WriteLine("222222222222222222222222222222222222222");
                while (true)
                {
                    string one_json = redis.redis_client.PopItemFromList("testDocTranslateFileJsonList");
                }
            }
        }
    }
}
