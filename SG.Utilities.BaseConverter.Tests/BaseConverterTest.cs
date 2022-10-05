namespace SG.Utilities.BaseConverter_Tests;

public abstract class BaseConverterTest
{
    protected IBaseConverter _baseConverter;
    protected int _radix { get { return _baseConverter.Base; } }

    [SetUp]
    public abstract void Setup();

    [Test]
    public virtual void RandomPositiveToBase()
    {
        var number = (long)new Random().Next(1, int.MaxValue);
        var netConverterResult = Convert.ToString(number, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertFromDec(number);

        Assert.That(baseConverterResult, Is.EqualTo(netConverterResult));
    }

    [Test]
    public virtual void RandomPositiveFromBase()
    {
        var number = (long)new Random().Next(1, int.MaxValue);
        var netConverterResult = Convert.ToString(number, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertToDec(netConverterResult);

        Assert.That(baseConverterResult, Is.EqualTo(number));
    }

    [Test]
    public virtual void ZeroToBase()
    {
        var netConverterResult = Convert.ToString(0, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertFromDec(0);

        Assert.That(baseConverterResult, Is.EqualTo(netConverterResult));
    }

    [Test]
    public virtual void ZeroFromBase()
    {
        var netConverterResult = Convert.ToString(0, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertToDec(netConverterResult);

        Assert.That(baseConverterResult, Is.EqualTo(0));
    }

    [Test]
    public virtual void RandomNegativeToBase()
    {
        var number = (long)new Random().Next(int.MinValue, -1);
        var netConverterResult = Convert.ToString(number, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertFromDec(number);

        Assert.That(baseConverterResult, Is.EqualTo(netConverterResult));
    }

    [Test]
    public virtual void RandomNegativeFromBase()
    {
        var number = (long)new Random().Next(int.MinValue, -1);
        var netConverterResult = Convert.ToString(number, toBase: _radix);
        var baseConverterResult = _baseConverter.ConvertToDec(netConverterResult);

        Assert.That(baseConverterResult, Is.EqualTo(number));
    }
}
