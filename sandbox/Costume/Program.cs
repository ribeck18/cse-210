namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Costume detective = new Costume();
        detective._headgear = "fedora";
        detective._shirt = "Trench Coat";
        detective.OutputReport();
    }
}
