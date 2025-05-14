using System;

namespace _05_13_CSharp
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }
    internal class EX
    {
        static void Main(string[] args)
        {
            ACSetting acs = new ACSetting();
            acs.currentInCelsius = 25;
            acs.target = acs.GetFahrenheit();

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
