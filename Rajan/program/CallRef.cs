//Write a program that swaps two integers using call by value. Does the swap work outside the methode? why?
using System;
class CallRef
{
    public void Swap(ref int a, ref int b)
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
        Swap(ref x,ref y);
        Console.WriteLine($"Original value of first num: {x} second num{y}");
    }
}