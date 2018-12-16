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

            var calendars = service.GetAvailableCalendars(true);
            
            foreach (var calendar in calendars)
            {
                Console.WriteLine("\nUpcoming events for {0}:", calendar.Summary);
                var events = service.GetThisWeeksEvents(calendar.Id);

                if (events != null && events.Count > 0)
                {
                    foreach (var eventItem in events)
                    {
                        string when = eventItem.Start.DateTime.ToString();
                        if (string.IsNullOrEmpty(when))
                        {
                            when = eventItem.Start.Date;
                        }

                        Console.WriteLine("{0} - {1} ({2})", calendar.Summary, eventItem.Summary, when);
                    }
                }
                else
                {
                    Console.WriteLine("No upcoming events found.");
                }
            }

            Console.WriteLine("\n\nPress enter to exit");
            Console.Read();

        }
    }
}