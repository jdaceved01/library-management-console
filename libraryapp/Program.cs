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
                ShowBooksMenu();
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

    static void ShowBooksMenu()
    {
        bool inBooksMenu = true;

        while (inBooksMenu)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("             Books Menu             ");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("1. Register Book");
            Console.WriteLine("2. List Book");
            Console.WriteLine("3. View Book Detail");
            Console.WriteLine("4. Update Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    RegisterBook();
                    break;
                case 2:
                    ListBooksMenu();
                    break;
                case 3:
                    ViewBookDetail();
                    break;
                case 4:
                    UpdateBookMenu();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 0:
                    inBooksMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void RegisterBook()
    {
        Console.Clear();

        Console.WriteLine("Register Book.");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Simulating book registration...");
        Console.WriteLine("Fields: ISBN, Title, Author, Category, Year");

        WaitForUser();
    }

    static void ListBooksMenu()
    {
        bool inListMenu = true;

        while (inListMenu)
        {
            Console.Clear();

            Console.WriteLine("List Books");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. List All");
            Console.WriteLine("2. List Available");
            Console.WriteLine("3. List Borrowed");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    ListBooksAll();
                    break;
                case 2:
                    ListBooksAvailable();
                    break;
                case 3:
                    ListBooksBorrowed();
                    break;
                case 0:
                    inListMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void ListBooksAll()
    {
        Console.Clear();

        Console.WriteLine("Listing All Books");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating listing all books...");

        WaitForUser();
    }

    static void ListBooksAvailable()
    {
        Console.Clear();

        Console.WriteLine("Listing available books...");
        WaitForUser();
    }

    static void ListBooksBorrowed()
    {
        Console.Clear();

        Console.WriteLine("Listing borrowed books...");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating listing of borrowed books...");

        WaitForUser();
    }

    static void ViewBookDetail()
    {
        Console.Clear();

        Console.WriteLine("View Book Detail");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating Book detail lookup by ISBN or ID.");

        WaitForUser();
    }

    static void UpdateBookMenu()
    {
        bool inUpdateMenu = true;

        while (inUpdateMenu)
        {
            Console.Clear();

            Console.WriteLine("Update Book");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Edit Title");
            Console.WriteLine("2. Edit Author");
            Console.WriteLine("3. Edit Year / Category");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    EditBookTitle();
                    break;
                case 2:
                    EditBookAuthor();
                    break;
                case 3:
                    EditBookYearAndCategory();
                    break;
                case 0:
                    inUpdateMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void EditBookTitle()
    {
        Console.Clear();

        Console.WriteLine("Edit Book Title");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating Title update.");

        WaitForUser();
    }

    static void EditBookAuthor()
    {
        Console.Clear();

        Console.WriteLine("Edit Book Author");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating Author update.");

        WaitForUser();
    }

    static void EditBookYearAndCategory()
    {
        Console.Clear();

        Console.WriteLine("Edit Book Year and Category");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating Year or Category update.");

        WaitForUser();
    }

    static void DeleteBook()
    {
        Console.Clear();

        Console.WriteLine("Delete Book");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Validation: do not allow deletion if the book is currently borrowed.");

        WaitForUser();
    }
}
