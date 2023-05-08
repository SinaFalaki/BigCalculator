using System.Numerics;


while (true)
{
     
    BigInteger Input1 = BigInteger.Parse("0");
    BigInteger Input2 = BigInteger.Parse("0");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\n\n\t\t\t\t\t    Welcome to Big Calculator :D");
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write("\n\n\t\t\t\t======================================================");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\n\n\t\t\t\t    please Enter your number 1 :");
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    try
    {
        Input1 = BigInteger.Parse(Console.ReadLine());

    }
    catch (Exception)
    {

        Console.WriteLine("\n\n\t\t\t\t\t    please only insert a number");
        Console.ReadKey();
        goto inja;
    }
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("\n\n\t\t\t\t    please Enter your number 2 :");
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    try
    {
        Input2 = BigInteger.Parse(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.WriteLine("\n\n\t\t\t\t\t    please only insert a number");
        Console.ReadKey();
        goto inja;

    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\n\n\t\t\t\t\t    Sum : +");
    Console.Write("\n\n\t\t\t\t\t    Subtract : -");
    Console.Write("\n\n\t\t\t\t\t    Multiply : *");
    Console.Write("\n\n\t\t\t\t\t    Divide : /");

    Console.Write("\n\n\t\t\t\t\t    please Enter your Opration :");
    string res = Console.ReadLine();

    BigInteger equevalent = BigInteger.Parse("0");

    switch (res)
    {
        case "+":
            {
                equevalent = Input1 + Input2;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n\t\t\t\t\tYour Result is : {equevalent}");
                break;
            }
        case "-":
            {
                equevalent = Input1 - Input2;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n\t\t\t\t\tYour Result is : {equevalent}");
                break;
            }
        case "*":
            {
                equevalent = Input1 * Input2;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n\t\t\t\t\tYour Result is : {equevalent}");
                break;
            }
        case "/":
            {
                equevalent = Input1 / Input2;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n\t\t\t\t\tYour Result is : {equevalent}");
                break;
            }
        default:
            {
                Console.WriteLine("\n\t\t\t\t\t    please inter Legal Operator...");
                break;
            }
    }


    Console.ReadKey();

    inja:
    Console.Clear();


}