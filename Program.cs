using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Angle
    {
        static void Main(string[] args)
        {   //Ask the user and store
            int hour, min;
            Console.WriteLine("Enter Hour:");
            hour=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minute:");
            min=Convert.ToInt32(Console.ReadLine());
            //The logic of the clock is that every hour is 30 degrees and every minute is 6 degrees
            double hrDeg=(hour*30)+(min*30/60);
            double minDeg = min * 6;

            //A condition when the diff is greater than 180 
            double diff=Math.Abs(hrDeg-minDeg);
            if (diff > 180)
                diff = 360 - diff;
            Console.WriteLine("The angle between minute and hour is:{0}",diff);
            Console.ReadLine();
        }
    }
}
