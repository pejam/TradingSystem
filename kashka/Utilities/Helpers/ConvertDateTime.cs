using MD.PersianDateTime.Core;
using System;

public static class ConvertDateTime
{
    public static DateTime ConvertShamsiToMiladi(string date)
    {
        PersianDateTime persianDateTime = PersianDateTime.Parse(date);
        return persianDateTime.ToDateTime();
    }

    public static string ConvertMiladiToShamsi(this DateTime? date, string format)
    {
        PersianDateTime persianDateTime = new PersianDateTime(date);
        return persianDateTime.ToString(format);
    }
}