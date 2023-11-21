namespace Datas;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        var data = new DateTime();
        Console.WriteLine(data);

        var datetimeUtc = DateTime.UtcNow;
        Console.WriteLine("Data utc0: " + datetimeUtc);

        Console.WriteLine("Hora local: " + datetimeUtc.ToLocalTime());

        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAustralia);

        foreach( var timezone in TimeZoneInfo.GetSystemTimeZones()) {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
        }

        Console.Clear();
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
    }

    static bool IsWeekend(DayOfWeek today) {
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
}