﻿using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            if (data.Date >= DateTime.Now.Date)
                Console.WriteLine("É igual");

            Console.WriteLine(data);

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