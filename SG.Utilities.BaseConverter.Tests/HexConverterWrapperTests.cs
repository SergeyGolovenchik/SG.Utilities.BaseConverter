namespace SG.Utilities.BaseConverter_Tests;

public class HexConverterWrapperTests : BaseConverterTest
{
    [SetUp]
    public override void Setup()
    {
        _baseConverter = new Base16Converter();
    }
}
