namespace CalendarCompressor.Models
{
    public interface IConfiguration
    {
        string[] Scopes { get; }

        string ApplicationName { get; }
    }
}