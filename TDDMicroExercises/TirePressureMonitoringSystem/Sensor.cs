using System;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{

    public class Sensor : ISensor
    {
        private const double Offset = 16;

        public double PopNextPressurePsiValue()
        {
            return Offset + SamplePressure();
        }


        private static readonly Random BasicRandomNumbersGenerator = new Random();


        private static double SamplePressure()
        {
            
            return 6 * BasicRandomNumbersGenerator.NextDouble() * BasicRandomNumbersGenerator.NextDouble();
        }
    }
}
