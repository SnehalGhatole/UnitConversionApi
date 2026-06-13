namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    public double Convert(double value, string from, string to)
    {
        from = from.ToLower();
        to = to.ToLower();

        if (from == "meter" && to == "feet")
            return value * 3.28084;

        if (from == "feet" && to == "meter")
            return value / 3.28084;
        if (from == "celsius" && to == "fahrenheit")
        {
            return (value * 9 / 5) + 32;
        }

        if (from == "fahrenheit" && to == "celsius")
        {
            return (value - 32) * 5 / 9;
        }

        if (from == "kilogram" && to == "pound")
        {
            return value * 2.20462;
        }

        if (from == "pound" && to == "kilogram")
        {
            return value / 2.20462;
        }

        throw new ArgumentException("Conversion not supported.");
    }
}