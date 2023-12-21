using ConverterApp.Entities;
using ConverterApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp.Strategies
{
    public class GBPConverter : IConverter
    {
        public JsonStringUploaderAndDeserializer JsonStringUploaderAndDeserializer { get; private set; }

        public Rate rate { get; private set; }

        public GBPConverter() 
        {
            JsonStringUploaderAndDeserializer = new JsonStringUploaderAndDeserializer("E:/Micrisoft VS/Projects/ConverterApp/ConverterApp/Rates.json");

            rate = JsonStringUploaderAndDeserializer.rates[2];

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
