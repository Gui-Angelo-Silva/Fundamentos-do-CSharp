using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;
            
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);
            
            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 18);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanHoraMinutoSegundoMilisegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            //var formatada = String.Format("{0:r}", data);
            //var data = new DateTime(2005, 07, 9, 8, 23, 14);
            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);

            // Console.WriteLine(data.DayOfWeek);
        }
    }
}