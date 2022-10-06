void DoWhileLoop()
{
    string userContinue = string.Empty;
    do
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Would you like to play again [y/n]?");
        userContinue = Console.ReadLine().ToLower().Trim();
    }
    while (userContinue != "n");

    Console.Clear();
    Console.WriteLine("Goodbye!\n");
    Console.WriteLine("Press enter to return to the main menu");
    Console.ReadKey();
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

        string playAgain = string.Empty;
        do
        {
            Console.WriteLine("\n\nWould you like to play again [y/n]?");
            playAgain = Console.ReadLine().ToLower().Trim();
            
            if(playAgain == "y")
            {
                Console.Clear();
                break;
            }
            else if (playAgain == "n")
            {
                Console.Clear();
                Console.WriteLine("Goodbye!\n");
                Console.WriteLine("Press enter to return to the main menu");
                Console.ReadKey();
                Console.Clear();

                loop = 0;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"'{playAgain}' is an invalid entry. Please enter 'y' or 'n'");
            }
        } while (playAgain != "y" || playAgain != "n");
    }
    Menu(); 
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
                numberOfAttempts--;

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
                numberOfAttempts--;
                
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
    bool isValidInput;
    int menuChoice;

    Console.WriteLine("Which loop would you like to run? \n");

    Console.WriteLine("1). Do-While Hello World Loop");
    Console.WriteLine("2). For Loops");
    Console.WriteLine("3). Keypad While Loop");
    Console.WriteLine("4). Keypad Do-While Loop");
    Console.WriteLine("5). Exit\n");

    Console.Write("Please enter a number: ");

    //int menuChoice = int.Parse(Console.ReadLine());

    do
    {
        isValidInput = int.TryParse(Console.ReadLine(), out menuChoice);
        if (isValidInput == false)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a number from the menu below:\n ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("1). ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do-While Hello World Loop");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("2). ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("For Loops");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("3). ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Keypad While Loop");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("4). ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Keypad Do-While Loop");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("5). ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exit\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter a number: ");

            
        }
    } while (isValidInput == false);

    switch (menuChoice)
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Option {menuChoice} does not exist. Please select an option from the menu below:\n");
            Console.ResetColor();
            Menu();
            break;
    } 
}

Menu();