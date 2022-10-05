using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.Utilities.BaseConverter_Tests;
public class ExceptionsTests
{
    IBaseConverter _converter = null;

    [SetUp]
    public void Setup() { }

    [Test]
    public void ShortAlphabetTest()
    {
        var exceptionTriggered = false;
        try
        {
            _converter = new BaseConverter("0");
        }
        catch (ArgumentOutOfRangeException)
        {
            exceptionTriggered = true;
        }

        Assert.IsTrue(exceptionTriggered);
    }

    [Test]
    public void DuplicateAlphabetTest()
    {
        var exceptionTriggered = false;
        try
        {
            _converter = new BaseConverter("00");
        }
        catch (ArgumentException)
        {
            exceptionTriggered = true;
        }

        Assert.IsTrue(exceptionTriggered);
    }

    [Test]
    public void Int64OverflowTest()
    {
        var exceptionTriggered = false;
        try
        {
            _converter = new BaseConverter(BaseAlphabet.BIN);
            var value = new string('1', 65);
            var converted = _converter.ConvertToDec(value);
        }
        catch (OverflowException)
        {
            exceptionTriggered = true;
        }

        Assert.IsTrue(exceptionTriggered);
    }
}
