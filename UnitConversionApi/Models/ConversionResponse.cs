namespace UnitConversionApi.Models;

public class ConversionResponse
{
    public double OriginalValue { get; set; }

    public string From { get; set; } = string.Empty;

    public string To { get; set; } = string.Empty;

    public double ConvertedValue { get; set; }
}