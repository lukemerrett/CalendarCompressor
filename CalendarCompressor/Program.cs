using CalendarCompressor.Models;
using CalendarCompressor.Services.Calendar;
using System;

namespace CalendarCompressor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var service = EventServiceFactory.GetAuthenticatedService(new StaticConfiguration());

            var events = service.GetUpcomingEvents(10);

            Console.WriteLine("Upcoming events:");

            if (events != null && events.Count > 0)
            {
                foreach (var eventItem in events)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (string.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }

            Console.WriteLine("\n\nPress enter to exit");
            Console.Read();

        }
    }
}