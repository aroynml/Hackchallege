using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackchallenge01.Methods
{
    public class GetDayofweek
    {

        public static string CheckValidDayofweek(string dateformat, int startyear, int checkyears = 50)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            string result = "";
            string dateString;
            List<System.DayOfWeek> validday = new List<System.DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };

            if (!string.IsNullOrWhiteSpace(dateformat) && dateformat.Contains('-'))
            {
                for (int i = 0; i < checkyears; i++)
                {
                    dateString = dateformat + "-" + (startyear + i);
                    if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", enUS, DateTimeStyles.None, out var dateValue))
                    {
                        var dow = dateValue.DayOfWeek;
                        if (validday.Contains(dow))
                        {
                            result += string.Format($"{dow.ToString().Substring(0, 3)}-{(startyear + i)} ");
                        }

                    }
                }
            }
            return result.Trim();
        }
    }
}
