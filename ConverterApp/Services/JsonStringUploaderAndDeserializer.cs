using ConverterApp.Entities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ConverterApp.Services
{
    public class JsonStringUploaderAndDeserializer
    {
        private string FilePath;

        public List<Rate> rates;

        public JsonStringUploaderAndDeserializer(string filePath)
        {
            FilePath = filePath;

            string json = File.ReadAllText(FilePath);

            rates = JsonSerializer.Deserialize<List<Rate>>(json);
        }




    }
}
