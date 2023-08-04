using Memorize_word_.Desktop.Constants;
using System;

namespace Memorize_word_.Healpers;

public class TimeHealpers
{
    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.UtcNow;
        dtTime.AddHours(TimeConstants.UTC);
        return dtTime;
    }
}
