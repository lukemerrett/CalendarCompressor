using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;

namespace CalendarCompressor.Services.Compressor
{
    public class CompressorService : ICompressorService
    {
        public IList<Event> CompressWeeksEvents(IList<Event> originalEvents)
        {
            throw new NotImplementedException("Core compression logic still to be written");
        }
    }
}
