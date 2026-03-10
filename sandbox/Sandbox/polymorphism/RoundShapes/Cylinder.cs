class Cylinder : Circle
{
    private double _height;

    public Cylinder(double r, double h):base(r)
    {
        _height = h;
    }
    public void SetHeight(double h) 
    {
        _height =h;
    }

    public override double Area()
    {
        return 2* Math.PI * _radius * (_radius + _height);
    }
}