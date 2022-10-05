namespace SG.Utilities.BaseConverter_Tests;

public class DecimalConverterTests
{
    private IBaseConverter _baseConverter;

    [SetUp]
    public void Setup()
    {
        _baseConverter = new BaseConverter(BaseAlphabet.ZeroToNine);
    }

    [Test]
    public void RandomPositiveToBase()
    {
        var random = (long)new Random().Next(1, int.MaxValue);
        var convertedValue = _baseConverter.ConvertFromDec(random);

        Assert.That(convertedValue, Is.EqualTo(random.ToString()));
    }

    [Test]
    public void RandomPositiveFromBase()
    {
        var random = (long)new Random().Next(1, int.MaxValue);
        var convertedValue = _baseConverter.ConvertToDec(random.ToString());

        Assert.That(convertedValue, Is.EqualTo(random));
    }

    [Test]
    public void ZeroToBase()
    {
        var convertedValue = _baseConverter.ConvertFromDec(0);

        Assert.That(convertedValue, Is.EqualTo("0"));
    }

    [Test]
    public void ZeroFromBase()
    {
        var convertedValue = _baseConverter.ConvertToDec("0");

        Assert.That(convertedValue, Is.EqualTo(0));
    }

    [Test]
    public void RandomNegativeToBase()
    {
        var random = (long)new Random().Next(int.MinValue, -1);
        var convertedValue = _baseConverter.ConvertFromDec(random);

        Assert.That(convertedValue, Is.EqualTo(((ulong)random).ToString()));
    }

    [Test]
    public void RandomNegativeFromBase()
    {
        var random = (long)new Random().Next(int.MinValue, -1);
        var convertedValue = _baseConverter.ConvertToDec(((ulong)random).ToString());

        Assert.That(convertedValue, Is.EqualTo(random));
    }
}
