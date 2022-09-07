namespace SG.Utilities;

/// <summary>
/// This class uses to override BaseConverter logic to fallback 
/// to Convert class in cases of Base2, Base8 and Base16
/// </summary>
public abstract class FrameworkBaseConverter : BaseConverter
{
    public FrameworkBaseConverter(string alphabet) : base(alphabet) { }

    public override string ConvertFromDec(long value)
    {
        return Convert.ToString(value, this.Base);
    }

    public override long ConvertToDec(string value)
    {
        return Convert.ToInt64(value, this.Base);
    }
}
