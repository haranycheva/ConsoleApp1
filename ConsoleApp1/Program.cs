
using System;public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numb = int.Parse(Console.ReadLine());
        int hundreds = numb / 100;
        int dozens = numb / 10 - hundreds * 10;
        int units = numb - (hundreds * 100 + dozens * 10);
        if (hundreds >= dozens & hundreds >= units)
        {
            if (dozens >= units)
            {
                Console.WriteLine($"{hundreds}{dozens}{units}");
            }
            else
            {
                Console.WriteLine($"{hundreds}{units}{dozens}");
            }
        }
        else if (dozens >= units)
        {
            if (hundreds >= units)
            {
                Console.WriteLine($"{dozens}{hundreds}{units}");
            }
            else
            {
                Console.WriteLine($"{dozens}{units}{hundreds}");
            }
        }
        else
        {
            if (hundreds >= dozens)
            {
                Console.WriteLine($"{units}{hundreds}{dozens}");
            }
            else
            {
                Console.WriteLine($"{units}{dozens}{hundreds}");
            }
        }
    }
}
