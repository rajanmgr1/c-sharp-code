using System;
class ValueCall
{
    public void Swap(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
        Console.WriteLine($"Swappewd value of first num: {a} second num {b}");

    }
    public void Send()
    {
        int x = 29;
        int y = 33;
        Swap(x,y);
        Console.WriteLine($"Original value of first num: {x} second num{y}");
    }
}