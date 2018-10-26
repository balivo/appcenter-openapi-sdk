using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balivo.AppCenterClient.ConsoleTest
{
    class Program
    {
        static IAppCenterClient AppCenterClient;

        static void Main(string[] args)
        {
            var token = "";

            AppCenterClient = new AppCenterClient(new AppCenterCredentials(token));

            Task.Factory.StartNew(async () =>
            {

                var pushResponse = await AppCenterClient.Push.SendAsync(new Models.NotificationDefinition { }, "", "");



            });


            Console.ReadLine();
        }
    }
}
