public static class DateTimeHelper
{
    public static long ToTimestamp(DateTime d)
    {
        var epoch = d - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
        return (long)epoch.TotalSeconds;
    }

    public static DateTime ToDateTime(long timestamp)
    {
        System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
        dateTime = dateTime.AddSeconds(timestamp);
    }    
}
