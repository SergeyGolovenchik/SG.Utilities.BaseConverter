namespace SG.Utilities.BaseConverter_Tests;

public class BinaryConverterWrapperTests : BaseConverterTest
{
    [SetUp]
    public override void Setup()
    {
        _baseConverter = new Base2Converter();
    }
}
