// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Dmytro");
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FeezBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Feez");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}