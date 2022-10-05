namespace SG.Utilities.BaseConverter_Tests;

public class HexConverterTests : BaseConverterTest
{
    [SetUp]
    public override void Setup()
    {
        _baseConverter = new BaseConverter(BaseAlphabet.HEX);
    }
}
