using ConverterApp.Entities;
using ConverterApp.Services;

namespace ConverterApp.Strategies
{
    public class JPYConverter : IConverter
    {
        public JsonStringUploaderAndDeserializer JsonStringUploaderAndDeserializer { get; private set; }

        public Rate rate { get; private set; }

        public JPYConverter()
        {
            JsonStringUploaderAndDeserializer = new JsonStringUploaderAndDeserializer("E:/Micrisoft VS/Projects/ConverterApp/ConverterApp/Rates.json");

            rate = JsonStringUploaderAndDeserializer.rates[3];
        }


        public double ConvertFromUSD(double value)
        {
            var rate = this.rate.Value;

            return rate * value;
        }

        public double ConvertToUSD(double value)
        {
            var rate = this.rate.Value;

            return value / rate;
        }
    }
}
