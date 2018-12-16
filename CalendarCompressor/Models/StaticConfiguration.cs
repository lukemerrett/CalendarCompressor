using Google.Apis.Calendar.v3;

namespace CalendarCompressor.Models
{
    public class StaticConfiguration : IConfiguration
    {
        public string[] Scopes => new[] { CalendarService.Scope.CalendarReadonly };

        public string ApplicationName => "Calendar Compressor";

    }
}
