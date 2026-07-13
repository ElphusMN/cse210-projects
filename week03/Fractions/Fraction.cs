public class Fraction
{
    private int _top;
    private int _bottom;

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFraction()
    {
        return $"{_top}/{_bottom}";
    }
}