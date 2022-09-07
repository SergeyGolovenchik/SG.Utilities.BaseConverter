namespace SG.Utilities;

/// <summary>
/// Converts integer from and to OCT.
/// </summary>
public sealed class Base8Converter : FrameworkBaseConverter
{
    private const string ALPHABET = BaseAlphabet.OCT;
    public Base8Converter() : base(ALPHABET) { }
}
