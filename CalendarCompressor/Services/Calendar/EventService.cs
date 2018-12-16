using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalendarCompressor.Extensions;
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

        public IList<CalendarListEntry> GetAvailableCalendars(bool onlyVisibleCalendars)
        {
            var request = _calendarService.CalendarList.List();
            
            var calendars = request.Execute();
            
            if (onlyVisibleCalendars)
            {
                return calendars.Items
                    .Where(c => c.Selected.HasValue && c.Selected.Value)
                    .ToList();
            }

            return calendars.Items;
        }

        public IList<Event> GetThisWeeksEvents(string calendarId)
        {
            var startOfTheWeek = DateTime.Now.StartOfWeek();
            var endOfTheWeek = startOfTheWeek.AddDays(7).AddMilliseconds(-1);

            var request = _calendarService.Events.List(calendarId);
            request.TimeMin = startOfTheWeek;
            request.TimeMax = endOfTheWeek;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 1000;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            var events = request.Execute();
            return events.Items;
        }
    }
}
