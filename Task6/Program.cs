using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

internal class Program
{
    class Traf_L
    {
        public void Light(int n, string all)
        {
            string[] strings = all.Split();

            for(int i = 0; i != n; i++)
            {

                foreach (string s in strings)
                {
                    Console.Write(s + " ");

                }
                Console.WriteLine();


                string temp = strings[strings.Length-1];


                for (int y = strings.Length - 1; y != 0; y--)
                {
                    strings[y] = strings[y - 1];
                }
                strings[0] = temp;

            }
        }
    }
    static void Main()
    {
        Traf_L a = new Traf_L();
        a.Light(3, "Green Yellow Red");
    }
}