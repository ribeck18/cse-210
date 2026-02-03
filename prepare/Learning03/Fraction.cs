public class Fraction
{
    //Attributes
    private int _topNumber;
    private int _bottomNumber;

    //Methods 

    //Constructors 
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    //getters & setters
    public int GetTop()
    {
        return _topNumber;
    }
    public int GetBottom()
    {
        return _bottomNumber;
    }
    public void SetTop(int top)
    {
        _topNumber = top;
    }
    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }


    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}"; 
    }
    public double GetDecimelValue()
    {
        double decimel = (double) _topNumber / _bottomNumber;
        return decimel;
    }
}