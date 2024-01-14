Console.WriteLine("Enter something:");

string userInput = Console.ReadLine();

PrintAnyWord(userInput);

static void PrintAnyWord (string parameter)
{
  
    for (int i = 0; i < 5; i++)
    {
    Console.WriteLine(parameter);
    }
}