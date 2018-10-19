using Balivo.AppCenterClient.Clients;
using Balivo.AppCenterClient.Resources.Push;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Balivo.AppCenterClient.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(async () =>
            {
                AppCenterHttpClient.Current.Authorize("......");

                var ownerName = "";
                var appName = "";

                var postPushResult = await PushService.Current.PostPush(ownerName, appName, new PostPushArgs
                {
                    Target = null,
                    Content = new PushContent
                    {
                        Title = "Teste",
                        Name = "Name Teste",
                        Body = "Body teste de mensagem"
                    }
                });

                Console.WriteLine(JsonConvert.SerializeObject(postPushResult, Formatting.Indented));
            });

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
