using System.Collections.Generic;
using Google.Apis.Calendar.v3.Data;

namespace CalendarCompressor.Services.Compressor
{
    public interface ICompressorService
    {
        IList<Event> CompressWeeksEvents(IList<Event> originalEvents);
    }
}