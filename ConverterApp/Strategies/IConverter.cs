namespace ConverterApp.Strategies
{
    public interface IConverter
    {
        double ConvertFromUSD(double value);

        double ConvertToUSD(double value);
    }
}
