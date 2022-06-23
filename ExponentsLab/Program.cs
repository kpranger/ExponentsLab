Console.WriteLine("Learn your squares and cubes!");
Console.WriteLine();
while (true)
{
    bool isValidInput = false;
    int num = 0;
    while (!isValidInput)
    {
        Console.WriteLine("Enter an integer: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0 && num < 1291)
        {
            isValidInput = true;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input, try again");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    if (num > 0 && num < 1291)
    {
        Console.WriteLine(String.Format("{0,7} {1,12} {2,15}","Number", "Squared", "Cubed"));
        Console.WriteLine(String.Format("{0,7} {1,12} {2,15}", "=======", "=======", "======="));
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(String.Format("{0,7} {1,12} {2,15}", i, Math.Pow(i, 2), Math.Pow(i, 3)));
        }
    }
    Console.WriteLine();
    Console.WriteLine("Continue? y/n");
    string loopChoice = Console.ReadLine();
    Console.WriteLine();
    if (loopChoice.ToLower().Trim() != "y")
    {
        break;
    }
}