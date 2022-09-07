namespace SG.Utilities;

/// <summary>
/// Converts integer from and to Base62.
/// </summary>
public class Base62Converter : BaseConverter
{
    private const string ALPHABET = BaseAlphabet.Base62;
    public Base62Converter() : base(ALPHABET) { }
}
