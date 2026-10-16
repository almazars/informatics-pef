using System;
using System.Collections.Generic;
using System.Text;

namespace PocitackaHezci
{
    public static class Vypocti
    {
        public static double Soucet(double x, double y) => x + y;
        public static double Rozdil(double x, double y) => x - y;
        public static double Soucin(double x, double y) => x * y;
        public static double Deleni(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Nelze dělit nulou.");
            }
            return x / y;
        }
        public static string Soucet(string x, string y)
        {
            return Soucet(Convert.ToDouble(x), Convert.ToDouble(y)).ToString();
        }
        public static string Rozdil(string x, string y)
        {
            return Rozdil(Convert.ToDouble(x), Convert.ToDouble(y)).ToString();
        }
        public static string Soucin(string x, string y)
        {
            return Soucin(Convert.ToDouble(x), Convert.ToDouble(y)).ToString();
        }
        public static string Deleni(string x, string y)
        {
            return Deleni(Convert.ToDouble(x), Convert.ToDouble(y)).ToString();
        }
    }
}
