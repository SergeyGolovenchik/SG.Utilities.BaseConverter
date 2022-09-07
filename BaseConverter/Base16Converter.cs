namespace SG.Utilities;

/// <summary>
/// Converts integer from and to HEX.
/// </summary>
public sealed class Base16Converter : FrameworkBaseConverter
{
    private const string ALPHABET = BaseAlphabet.HEX;
    public Base16Converter() : base(ALPHABET) { }
}
