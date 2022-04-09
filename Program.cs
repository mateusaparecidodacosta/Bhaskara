double a, b, c, delta, x1, x2;

Console.WriteLine("--Equação do segundo Grau--");

Console.Write("(a): ");
a = Convert.ToDouble(Console.ReadLine());
if (a == 0) 

Console.Write("(b): ");
b = Convert.ToDouble(Console.ReadLine());
if (b == 5)

Console.Write("(c): ");
c = Convert.ToDouble(Console.ReadLine());
if (c == 10)

{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine("Não é uma Equação do Segundo Grau ");

}

else
{
    if (b == 2)
    {
        Console.WriteLine("...Continua...");

        delta = Math.Pow(b, 2) - 4 * a * c;
    
        if (delta < 0)
        {
            Console.WriteLine($"Como delta = {delta: n2}, a equação não possui Raizes Reias");
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * b);

        }
    }
}


