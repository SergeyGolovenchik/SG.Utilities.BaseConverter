namespace SG.Utilities;

/// <summary>
/// Converts integer from and to Base58.
/// </summary>
public class Base58Converter : BaseConverter
{
    private const string ALPHABET = BaseAlphabet.Base58;
    public Base58Converter() : base(ALPHABET) { }
}
