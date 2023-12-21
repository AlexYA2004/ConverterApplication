using ConverterApp.Entities;
using ConverterApp.Services;

namespace ConverterApp.Strategies
{
    public class RUBConverter : IConverter
    {
        public JsonStringUploaderAndDeserializer JsonStringUploaderAndDeserializer { get; private set; }

        public Rate rate { get; private set; }

        public RUBConverter()
        {
            JsonStringUploaderAndDeserializer = new JsonStringUploaderAndDeserializer("E:/Micrisoft VS/Projects/ConverterApp/ConverterApp/Rates.json");

            rate = JsonStringUploaderAndDeserializer.rates[1];
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
