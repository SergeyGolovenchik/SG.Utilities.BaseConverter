namespace SG.Utilities.BaseConverter_Tests;

public class OctConverterTests : BaseConverterTest
{
    [SetUp]
    public override void Setup()
    {
        _baseConverter = new BaseConverter(BaseAlphabet.OCT);
    }
}
