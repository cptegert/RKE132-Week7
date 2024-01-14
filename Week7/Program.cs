Console.WriteLine("Tere, sisse välja? (in/out):");

string userChoise = Console.ReadLine();

if (userChoise == "in")
{
    PrintHello()
    ;
}
else if (userChoise == "out")
{
    Bye();
}
else
{
    Console.WriteLine("...");
}

static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}


static void Bye() 
{ 
    Console.WriteLine("Bye..!"); 
}


