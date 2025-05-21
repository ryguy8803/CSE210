using System;
using System.IO.Compression;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int whole)
    {
        _top = whole;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string getfractionstring()
    {
        string rep = $"{_top} / {_bottom}";
        return rep;
    }

    public double getdecimalvalue()
    {
        // (double) gets rid of int division 
        double value = (double)_top / _bottom;
        return value;
    }
}
