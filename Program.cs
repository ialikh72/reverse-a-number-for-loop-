using System;
class Reverse
{
    static void Main()
    {
        int rev=Reversee();
        Console.WriteLine("R="+rev);
    }
    static int Reversee()
    {
        Console.WriteLine(" enter a number to reverse:");
        int num=int.Parse(Console.ReadLine());
        int rev = 0;
        for (;num > 0;)
        {
            rev = rev * 10 + num % 10;
            num=num / 10;
        }
        return rev;
    }
}
