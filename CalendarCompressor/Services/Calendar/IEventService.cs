using Google.Apis.Calendar.v3.Data;
using System.Collections.Generic;

namespace CalendarCompressor.Services.Calendar
{
    public interface IEventService
    {
        IList<Event> GetUpcomingEvents(int maxResults);
    }
}
