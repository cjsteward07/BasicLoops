Console.WriteLine("-Basic Loops Lab-\n");

//string userContinue = string.Empty;
//do
//{
//    Console.WriteLine("Hello, World");
//    Console.WriteLine("Would you like to continue [y/n]?");
//    userContinue = Console.ReadLine().ToLower().Trim();
//}
//while (userContinue != "n");

Console.WriteLine("Please enter a number: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < userNumber; i ++)
{
    userNumber--;
    Console.WriteLine(userNumber);
}