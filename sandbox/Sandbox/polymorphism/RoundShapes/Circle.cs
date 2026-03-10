class Circle: RoundShape
{
    protected double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double Area()
    {
        

        return Math.PI * _radius * _radius;
    }
    
}