namespace UnitConversionApi.Services;

public interface IConversionService
{
    double Convert(double value, string from, string to);
}