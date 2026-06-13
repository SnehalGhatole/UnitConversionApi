namespace UnitConversionApi.Models;

public class ConversionRequest
{
    public double Value { get; set; }

    public string From { get; set; } = string.Empty;

    public string To { get; set; } = string.Empty;
}