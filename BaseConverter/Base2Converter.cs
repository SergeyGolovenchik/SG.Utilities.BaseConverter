namespace SG.Utilities;

/// <summary>
/// Converts integer from and to BIN.
/// </summary>
public sealed class Base2Converter : FrameworkBaseConverter
{
    private const string ALPHABET = BaseAlphabet.BIN;
    public Base2Converter() : base(ALPHABET) { }
}
