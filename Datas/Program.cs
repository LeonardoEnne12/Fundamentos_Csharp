using System;
using System.Globalization;


namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020,2));

            var timeSpan = new TimeSpan();

            Console.WriteLine(timeSpan);

            var timeSpanNanoSec = new TimeSpan(1); //Horário bem preciso
            Console.WriteLine(timeSpanNanoSec);
            
            var timeSpanMiliSec = new TimeSpan(15,12,55,8,100);
            Console.WriteLine(timeSpanMiliSec);

            // var pt = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var atual = CultureInfo.CurrentCulture;
            // var date =  DateTime.UtcNow;

            // Console.WriteLine(DateTime.Now.ToString("D",atual));
            
            // Console.WriteLine(date);
            // Console.WriteLine(date.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var timeAustralia = TimeZoneInfo.ConvertTimeFromUtc(date,timezoneAustralia);
            // Console.WriteLine(timeAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(date,timezone));
            //     Console.WriteLine("---------------");
            // }

            // var data = new DateTime(2020,10,12,23,13,29);
            // var data = DateTime.Now;
            // Console.WriteLine(data);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.DayOfWeek);

            // var formatada = String.Format("{0:yyyy}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:M}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:yyyy-MM-dd}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:dd/MM/yyyy}",data);
            // Console.WriteLine(formatada);

            // formatada = String.Format("{0:s}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:T}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:g}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:r}",data);
            // Console.WriteLine(formatada);
            // formatada = String.Format("{0:u}",data);
            // Console.WriteLine(formatada);

            // Console.WriteLine(data);
            // Console.WriteLine(data.AddDays(10));
            // Console.WriteLine(data.AddMonths(3));
            // Console.WriteLine(data.AddYears(2));
            
            // if (data.Date == DateTime.Now.Date)
            // {
            //     Console.WriteLine("É igual");
            // }

        }
    }
}
