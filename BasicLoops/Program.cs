void DoWhileLoop()
{
    string userContinue = string.Empty;
    do
    {
        Console.WriteLine("Hello, World");
        Console.WriteLine("Would you like to play again [y/n]?");
        userContinue = Console.ReadLine().ToLower().Trim();
    }
    while (userContinue != "n");

    Console.Clear();
    Menu();
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

        Console.WriteLine("\n\nWould you like to play again [y/n]?");
        string playAgain = Console.ReadLine().ToLower().Trim();
        
        if(playAgain == "y")
        {
            Console.Clear();
            continue;
        }
        else
        {
            Console.Clear();
            // Console.WriteLine("Goodbye!");
            loop = 0;
            Menu();
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
                door = "unlocked";

                Console.Clear();
                Console.WriteLine($"Welcome. {userInput} is CORRECT!\n");
                Console.WriteLine("Press enter to return to main menu");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (userInput != CODE && numberOfAttempts > 0)
            {
                numberOfAttempts = numberOfAttempts - 1;

                Console.Clear();
                Console.WriteLine($"{userInput} is incorrect. {numberOfAttempts} attempts remaining. Please try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("WARNING! Too many incorrect attempts. Please try again later.\n");
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    }

    Menu();
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
                door = "unlocked";

                Console.Clear();
                Console.WriteLine($"Welcome. {userInput} is CORRECT!\n");
                Console.WriteLine("Press enter to return to main menu");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (userInput != CODE && numberOfAttempts > 0)
            {
                numberOfAttempts = numberOfAttempts - 1;
                
                Console.Clear();
                Console.WriteLine($"{userInput} is incorrect. {numberOfAttempts} attempts remaining. Please try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("WARNING! Too many incorrect attempts. Please try again later.\n");
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadKey();
            Console.Clear();
            break;
            
        }
    }
    while (door == "locked");

    Menu();
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

    Console.Write("Please enter a number: ");

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
        default:
            Console.Clear();
            Console.WriteLine("Invalid choice. Please try again.\n");
            Menu();
            break;
    }
}

Menu();