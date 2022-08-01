using System;
using System.Collections.Generic;

namespace tempratures
{
    class Program
    {
        static int GreaterCount(List<double> list, double min)
        {
            int count = 0;
            foreach(double a in list)
            {
                if(a >= min)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            List<double> temp = new List<double>();
            temp.Add(20.5);
            temp.Add(23.7);
            temp.Add(32.1);
            temp.Add(40.1);
            temp.Add(30.0);

            Console.WriteLine("The Temperatures exceeds 25 degrees : " + GreaterCount(temp, 25.0));
        }
    }
}


/*
public static implicit operator Time(int i)
{
    Time t = new Time(, i);
    return t;

}*/

/*public static explicit operator int(Time t)
{
    int i = (int)t;
    return i;
}*/