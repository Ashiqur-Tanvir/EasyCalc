namespace EasyCalc.Contracts
{
    /// <summary>
    /// Interface for temparature conversion.
    /// </summary>
    public interface ITemperature
    {
        /// <summary>
        /// Converts temperature from celsius to farenheit.
        /// </summary>
        /// <param name="temperature">Temperature in celsius.</param>
        /// <returns>Temperature in farenheit.</returns>
        double CelsiusToFarenheit(double temperature); 
    }
}
