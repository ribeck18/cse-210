using System.Drawing;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

class Circle : Shape
{
    double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}