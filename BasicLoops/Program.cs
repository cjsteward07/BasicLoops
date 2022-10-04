void DoWhileLoop()
{
    string userContinue = string.Empty;
    do
    {
    Console.WriteLine("Hello, World");
    Console.WriteLine("Would you like to continue [y/n]?");
    userContinue = Console.ReadLine().ToLower().Trim();
    }
    while (userContinue != "n");
}

void ForLoops()
{
    int loop = 1;

    while(loop == 1)
    {
        Console.WriteLine("Please enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"User Input: {userNumber}\n");

        for (int i = 0; i <= userNumber; i++)
        {
            int subtractNumbers = userNumber - i;
            Console.Write($"{subtractNumbers} ");
        }
        Console.WriteLine("");
        for (int i = 0; i <= userNumber; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("\n\nWould you like to continue [y/n]?");
        string playAgain = Console.ReadLine().ToLower().Trim();
        
        if(playAgain == "y")
        {
            Console.Clear();
            continue;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            loop = 0;
        }
    }
}

void KeypadWhileLoop()
{
    string door = "locked";
    const int CODE = 13579;
    int numberOfAttempts = 5;

    while (door == "locked")
    {
        if (numberOfAttempts > 0)
        {
            Console.WriteLine("Please enter the combination: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == CODE)
            {
                Console.Clear();
                Console.WriteLine($"Welcome. {userInput} is CORRECT!");
                door = "unlocked";
            }
            else if (userInput != CODE && numberOfAttempts > 0)
            {
                Console.Clear();
                numberOfAttempts = numberOfAttempts - 1;
                Console.WriteLine($"{userInput} is incorrect. {numberOfAttempts} attempts remaining. Please try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("WARNING! Too many incorrect attempts. Please try again later.");
            Environment.Exit(0);
        }
    }
}

void KeypadDoWhileLoop()
{
    string door = "locked";
    const int CODE = 13579;
    int numberOfAttempts = 5;

    do
    {
        if (numberOfAttempts > 0)
        {
            Console.WriteLine("Please enter the combination: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == CODE)
            {
                Console.Clear();
                Console.WriteLine($"Welcome. {userInput} is CORRECT!");
                door = "unlocked";
            }
            else if (userInput != CODE && numberOfAttempts > 0)
            {
                Console.Clear();
                numberOfAttempts = numberOfAttempts - 1;
                Console.WriteLine($"{userInput} is incorrect. {numberOfAttempts} attempts remaining. Please try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("WARNING! Too many incorrect attempts. Please try again later.");
            Environment.Exit(0);
        }
    }
    while (door == "locked");
}





void Menu()
{
    Console.WriteLine("-Basic Loops Lab-\n");
    Console.WriteLine("Which loop would you like to run? \n");

    Console.WriteLine("1). Do-While Hello World Loop");
    Console.WriteLine("2). For Loops");
    Console.WriteLine("3). Keypad While Loop");
    Console.WriteLine("4). Keypad Do-While Loop");
    Console.WriteLine("5). Exit\n");

    Console.Write("Choice: ");

    int menuChoice = int.Parse(Console.ReadLine());

    switch(menuChoice)
    {
        case 1:
            Console.Clear();
            DoWhileLoop();
            break;
        case 2:
            Console.Clear();
            ForLoops();
            break;
        case 3:
            Console.Clear();
            KeypadWhileLoop();
            break;
        case 4:
            Console.Clear();
            KeypadDoWhileLoop();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Goodbye!");
            break;
    }
}

Menu();