class Triangle
{
    protected int _a;
    protected int _b;
    protected int _c;
    protected int _color;

    public Triangle(int a, int b, int c, int color)
    {
        _a = a;
        _b = b;
        _c = c;
        _color = color;
    }

    public override string ToString()
    {
        return $"Triangle: a = {_a}, b = {_b}, c = {_c}, color = {_color}";
    }

    public int GetPerimeter()
    {
        return _a + _b + _c;
    }

    public double GetArea()
    {
        var p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }


    public int A
    {
        get { return _a; }
        set
        {

            if (value <= 0)
            {
                throw new Exception("a must be > 0");
            }
            else
            {
                _a = value;
            }
        }

    }
    public int B
    {
        get { return _b; }
        set
        {

            if (value <= 0)
            {
                throw new Exception("b must be > 0");
            }
            else
            {
                _b = value;
            }
        }

    }
    public int C
    {
        get { return _c; }
        set
        {

            if (value <= 0)
            {
                throw new Exception("c must be > 0");
            }
            else
            {
                _c = value;
            }
        }

    }
    public int Color
    {
        get { return _color; }

    }

    public static void ShowTriangles(IEnumerable<Triangle> triangles)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var triangle in triangles)
        {
            Console.WriteLine(triangle);
            Console.WriteLine($"Perimetr = {triangle.GetPerimeter()}");
            Console.WriteLine($"Area = {triangle.GetArea()}");
            Console.WriteLine(new String('-', 45));
        }
        Console.ResetColor();
    }
}