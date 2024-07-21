using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Q3
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string massage)
        {
            Console.WriteLine($"push notification to  {recipient}");
            Console.WriteLine("Massage");
            Console.WriteLine(massage);
            Console.WriteLine("notification pushed");
        }
    }
}
