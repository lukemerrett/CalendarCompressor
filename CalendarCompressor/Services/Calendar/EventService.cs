using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;

namespace CalendarCompressor.Services.Calendar
{
    public class EventService : IEventService
    {
        private readonly CalendarService _calendarService;

        public EventService(CalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public IList<Event> GetUpcomingEvents(int maxResults)
        {
            // Define parameters of request.
            var request = _calendarService.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = maxResults;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();

            return events.Items;
        }
    }
}
