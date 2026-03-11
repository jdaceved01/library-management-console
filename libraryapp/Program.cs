using System;

class Program
{
    static void Main()
    {
        Console.Title = "Library Management System";
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            ShowMainMenu();

            int option = GetMenuOption();
            handleMainMenuOption(option, ref isRunning);
        }
    }

    static void ShowMainMenu()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("     Library Management System     ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("1. Books");
        Console.WriteLine("2. Users");
        Console.WriteLine("3. Loans");
        Console.WriteLine("4. Search and Reports");
        Console.WriteLine("5. Save / Load Data");
        Console.WriteLine("6. Exit");
        Console.WriteLine();
        Console.Write("Select an option: ");
    }

    static int GetMenuOption()
    {
        string? input = Console.ReadLine();
        int option;
        while (!int.TryParse(input, out option))
        {
            ShowInvalidOptionMessage();
            input = Console.ReadLine();
        }
        return option;
    }

    static void handleMainMenuOption(int option, ref bool isRunning)
    {
        switch (option)
        {
            case 1:
                Console.WriteLine("Books menu selected.");
                break;
            case 2:
                Console.WriteLine("Users menu selected.");
                break;
            case 3:
                Console.WriteLine("Loans menu selected.");
                break;
            case 4:
                Console.WriteLine("Search and Reports menu selected.");
                break;
            case 5:
                Console.WriteLine("Persistence menu selected.");
                break;
            case 6:
                isRunning = false;
                break;
            default:
                ShowInvalidOptionMessage();
                break;
        }
    }

    static void ShowInvalidOptionMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Invalid option. Please try again.");
        Console.Write("Select an option: ");
    }

    static void WaitForUser()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
