Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string? userInput = Console.ReadLine();

string userName = string.IsNullOrWhiteSpace(userInput) ? "NoName" : userInput ?? "NoName";

Console.WriteLine($"Welcome {userName}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
string? userAnswer = Console.ReadLine();

if (userAnswer?.Equals("No", StringComparison.OrdinalIgnoreCase) == true)
{
    Console.WriteLine($"You are a coward {userName}.");
}
else if (userAnswer?.Equals("Yes", StringComparison.OrdinalIgnoreCase) == true)
{
    Console.WriteLine("Heads or Tails?");
    int scoreTally = 0;

    for (int i = 0; i < 5; i++)
    {
        int randomResult = new Random().Next(0, 2);
        string? guessInput = Console.ReadLine();

        if ((randomResult == 0 && string.Equals(guessInput, "Heads", StringComparison.OrdinalIgnoreCase)) ||
            (randomResult == 1 && string.Equals(guessInput, "Tails", StringComparison.OrdinalIgnoreCase)))
        {
            scoreTally++;
            Console.WriteLine("Correct!");

            if (i < 4)
            {
                Console.WriteLine("Heads or Tails?");
            }
        }
        else
        {
            Console.WriteLine("Wrong!");

            if (i < 4)
            {
                Console.WriteLine("Heads or Tails?");
            }
        }
    }

    Console.WriteLine($"Thank you {userName}. You got a score of {scoreTally}!");
}
else
{
    Console.WriteLine("Invalid input. Please enter either 'Yes' or 'No'.");
}
