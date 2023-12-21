using ConverterApp.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp.Services
{
    public class MoneyChanger
    {
        private double moneyCount;

        private IConverter converter;

        public MoneyChanger(double value)
        {
            moneyCount = value;
        }

        public void SetConverter(IConverter inputConverter) 
        {
            converter = inputConverter;
        }


        public double GetMoney() 
        { 
            return converter.ConvertToUSD(moneyCount);
        }

        public double ChangeMoney()
        {
            return converter.ConvertFromUSD(moneyCount);
        }

    }
}
