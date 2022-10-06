using System;
using System.Runtime.InteropServices;

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
    int userInput = 0;
    bool isValidInput;
    const int CODE = 13579;
    int numberOfAttempts = 5;

    while (door == "locked")
    {
        if (numberOfAttempts > 0)
        {
            do
            {
                Console.WriteLine("Please enter the combination: ");
                isValidInput = int.TryParse(Console.ReadLine(), out userInput);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number");
                    Console.ResetColor();
                }
            } while (isValidInput == false);

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
    bool isValidInput;
    int userInput = 0;
    const int CODE = 13579;
    int numberOfAttempts = 5;

    do
    {
        if (numberOfAttempts > 0)
        {
            do
            {
                Console.WriteLine("Please enter the combination: ");
                isValidInput = int.TryParse(Console.ReadLine(), out userInput);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number");
                    Console.ResetColor();
                }
            } while (isValidInput == false);

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

bool StretchKeypadReturnMethod()
{
    bool doorLocked = true;
    const int CODE = 13579;
    int numberOfAttempts = 5;
    int userInput = 0;

    while (numberOfAttempts > 0 && doorLocked == true && userInput != CODE)
    {
        Console.WriteLine("Please enter the combination: ");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == CODE)
        {
            doorLocked = false;
            Console.Clear();
            Console.WriteLine($"Welcome. {userInput} is CORRECT!\n");
            return doorLocked;
        }
        numberOfAttempts--;
        Console.Clear();
        Console.WriteLine($"{userInput} is incorrect. {numberOfAttempts} attempts remaining. Please try again");
    }
    Console.Clear();
    Console.WriteLine("WARNING! Too many incorrect attempts. Please try again later.\n");
    return doorLocked;
}

void MenuOptions( [Optional] bool doorLocked)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Which loop would you like to run?");

    Console.Write("1). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Do-While Hello World Loop");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("2). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("For Loops");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("3). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Keypad While Loop");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("4). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Keypad Do-While Loop");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("5). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    if (doorLocked == true)
    {
        Console.Write("Stretch Keypad Return Method: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Door Locked");
    }
    else if (doorLocked == false)
    {
        Console.Write("Stretch Keypad Return Method: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Door Unlocked!");
    }
    else
    {
        Console.WriteLine("Stretch Keypad Return Method");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("6). ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Exit");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please enter a number: ");
    Console.ResetColor();
}

void Menu(bool doorLocked = true)
{
    bool isValidInput;
    int menuChoice;

    MenuOptions(doorLocked);

    do
    {
        isValidInput = int.TryParse(Console.ReadLine(), out menuChoice);
        if (isValidInput == false)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a NUMBER from the menu below:\n");
            MenuOptions(doorLocked);
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
            doorLocked = StretchKeypadReturnMethod();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadKey();
            Console.Clear();
            Menu(doorLocked);
            break;
        case 6:
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