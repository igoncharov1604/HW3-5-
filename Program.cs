class ThreeD
{
    int x, y, z; // Тривимірні координати
    public ThreeD() { x = y = z = 0; }
    public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

    // Перевантажити бінарний оператор +
    public static ThreeD operator +(ThreeD opl, ThreeD op2)
    {
        return new ThreeD(opl.x + op2.x, opl.y + op2.y, opl.z + op2.z);
    }

    // Перевантажити бінарний оператор -
    public static ThreeD operator -(ThreeD opl, ThreeD op2)
    {
        return new ThreeD(opl.x - op2.x, opl.y - op2.y, opl.z - op2.z);
    }

    // Вивести координати X, Y, Z.
    public void Show() => Console.WriteLine($"({x}, {y}, {z})");
}

class ThreeDDemo
{
    static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c;

        Console.Write("Координати точки а: ");
        a.Show();

        Console.Write("Координати точки b: ");
        b.Show();

        c = a + b; // скласти координати точок а та b
        Console.Write("Результат складання а + b: ");
        c.Show();

        c = a + b + c; // Скласти координати точок a, b і с
        Console.Write("Результат складання а + b + с: ");
        c.Show();

        c = c - a; // відняти координати точки а
        Console.Write("Результат віднімання с - а: ");
        c.Show();

        c = c - b; // відняти координати точки b
        Console.Write("Результат віднімання с - b: ");
        c.Show();

        Console.ReadKey();
    }
}
