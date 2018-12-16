using Google.Apis.Calendar.v3.Data;
using System.Collections.Generic;

namespace CalendarCompressor.Services.Calendar
{
    public interface IEventService
    {
        IList<CalendarListEntry> GetAvailableCalendars(bool onlyVisibleCalendars);

        IList<Event> GetUpcomingEvents(string calendarId, int maxResults);
    }
}
