
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
            Console.WriteLine("Press enter to exit the application.");
            break;
        }
    }
    while (door == "locked");
}

KeypadDoWhileLoop();
