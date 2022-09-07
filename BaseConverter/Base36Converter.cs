namespace SG.Utilities;

/// <summary>
/// Converts integer from and to Base36.
/// </summary>
public class Base36Converter : BaseConverter
{
    private const string ALPHABET = BaseAlphabet.Base36;
    public Base36Converter() : base(ALPHABET) { }
}
