namespace SG.Utilities.BaseConverter_Tests;

public class BinaryConverterTests : BaseConverterTest
{
    [SetUp]
    public override void Setup()
    {
        _baseConverter = new BaseConverter(BaseAlphabet.BIN);
    }
}
