// implementing the fraction class.

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

        
    }

    public Fraction(int aWholeNumber)
    {
        _top = aWholeNumber;
        _bottom = 1;
    }

    public Fraction(int aTop, int aBottom)
    {
        _top = aTop;
        _bottom = aBottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double) _top/(double) _bottom;
    }

}