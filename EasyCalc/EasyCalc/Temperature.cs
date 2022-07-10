using EasyCalc.Contracts;

namespace EasyCalc
{
    /// <inheritdoc cref="ITemperature"/>
    public class Temperature : ITemperature
    {
        /// <inheritdoc cref="ITemperature.CelsiusToFarenheit"/>
        public double CelsiusToFarenheit(double temperature)
        {
            var temperatureInFarenheit = (temperature * 1.8) + 32;

            if (temperatureInFarenheit >  70) 
            {
                Console.WriteLine("Heute ist sehr warm!");
            }

            return temperatureInFarenheit;
        }
    }
}