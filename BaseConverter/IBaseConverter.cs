namespace SG.Utilities;

public interface IBaseConverter
{
    /// <summary>
    /// Alphabet of base
    /// </summary>
    string Alphabet { get; }

    /// <summary>
    /// Length of base's alphabet
    /// </summary>
    byte Base { get; }

    /// <summary>
    /// Converts Int64 value to desired base using alphabet
    /// </summary>
    /// <param name="value">Value to convert</param>
    /// <returns>Converted value</returns>
    long ConvertToDec(string value);

    /// <summary>
    /// Converts string representation of BaseN value to DEC using alphabet
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Number in decimal base</returns>
    string ConvertFromDec(long value);
}
