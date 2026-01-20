using System.IO.Pipelines;

class Costume
{
    // Attributes
    string _headgear;
    string _shirt;
    string _pants;
    string _acssesories;
    string _footwear;

    // Behaviors (Methods)
    void OutputReport()
    {
        string result;
        result = $"\nHead: {_headgear}\nShirt; {_shirt}\n";
        Console.WriteLine(result);
    }
}