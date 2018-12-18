using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Date
    {
        public int Year { get; private set; }

        public int Month { get; private set; }

        public int Day { get; private set; }

        public Date(int year, int month, int day)
        {
            Year = year; Month = month; Day = day;
        }

        public void AddDay(int days)
        {
            Day += days;
            Normalize();
        }

        public void AddMonthDay(int month, int day)
        {
            Month += month;
            Day += day;
            Normalize();
        }
        public void AddAnotherDate(Date other)
        {
            Day += other.Day;
            Month += other.Month;
            Year += other.Year;
            Normalize();
        }
        private void Normalize()
        {
            if (Day > 30)
            {
                Day = Day - 30;
                Month += 1;
            }
            if (Month > 12)
            {
                Month = Month - 12;
                Year += 1;
            }
        }
        public override string ToString()
        {
            return $" Year:{Year} | Month:{Month} | Day:{Day}";
        }
    }
}
