using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    enum TimeFormat { Mil, Hour12, Hour24 }
    class Time
    {
        public int Hour { get; private set; }
        public int Minute { get; private set; }

        static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        private void Normalize()
        {
            Hour = (Hour > 24 || Hour < 0) ? 0 : Hour;
            Minute = (Minute > 60 || Minute < 0) ? 0 : Minute;

        }
        public Time(int hour = 0, int minute = 0)
        {
            Hour = hour; Minute = minute;
            Normalize();

        }
        public static void SetFormat(TimeFormat time_format)
        {
            TIME_FORMAT = time_format;
        }
        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:d2}{Minute:d2}";
                    break;
                case TimeFormat.Hour24:
                    return $"{Hour:d2}:{Minute:d2} {(Hour > 12 && Hour < 24 ? "PM" : "AM")}";
                    break;
                default:
                    return $"{(Hour - 12 > 0 ? Hour-12 : Hour)}:{Minute:d2} {(Hour-12>0 ? "PM" :"AM")}";
                    break;
            }
        }

    }
}
