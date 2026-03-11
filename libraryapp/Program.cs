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
                ShowUsersMenu();
                break;
            case 3:
                ShowLoansMenu();
                break;
            case 4:
                ShowSearchAndReportsMenu();
                break;
            case 5:
                ShowPersistenceMenu();
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

    //Users menu
    static void ShowUsersMenu()
    {
        bool inUsersMenu = true;

        while (inUsersMenu)
        {
            Console.Clear();

            Console.WriteLine("========== Users Menu ==========");
            ;
            Console.WriteLine();
            Console.WriteLine("1. Register User");
            Console.WriteLine("2. List Users");
            Console.WriteLine("3. View User Detail");
            Console.WriteLine("4. Update User");
            Console.WriteLine("5. Delete User");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    RegisterUser();
                    break;
                case 2:
                    ListUsers();
                    break;
                case 3:
                    ViewUserDetail();
                    break;
                case 4:
                    UpdateUser();
                    break;
                case 5:
                    DeleteUser();
                    break;
                case 0:
                    inUsersMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void RegisterUser()
    {
        Console.Clear();

        Console.WriteLine("Register User");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating user registration...");
        Console.WriteLine("Fields: ID, Name, Phone, or Email, Active status");

        WaitForUser();
    }

    static void ListUsers()
    {
        Console.Clear();

        Console.WriteLine("List Users");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating listing of all users");

        WaitForUser();
    }

    static void ViewUserDetail()
    {
        Console.Clear();

        Console.WriteLine("View User Detail");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating user lookup by ID or document");

        WaitForUser();
    }

    static void UpdateUser()
    {
        bool inUpdateMenu = true;

        while (inUpdateMenu)
        {
            Console.Clear();

            Console.WriteLine("Update User");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit Contact Info");
            Console.WriteLine("3.Activate / Deactivate");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    EditUserName();
                    break;
                case 2:
                    EditUserContactInfo();
                    break;
                case 3:
                    ToggleUserActiveStatus();
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

    static void EditUserName()
    {
        Console.Clear();

        Console.WriteLine("Edit User Name");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating user name update.");

        WaitForUser();
    }

    static void EditUserContactInfo()
    {
        Console.Clear();

        Console.WriteLine("Edit User Contact Info");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating phone/email update.");

        WaitForUser();
    }

    static void ToggleUserActiveStatus()
    {
        Console.Clear();

        Console.WriteLine("Activate / Deactivate User");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating change of user active status.");

        WaitForUser();
    }

    static void DeleteUser()
    {
        Console.Clear();

        Console.WriteLine("Delete User");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Validation: do not allow deletion if the user has active loans.");

        WaitForUser();
    }

    //Loans menu
    static void ShowLoansMenu()
    {
        bool inLoansMenu = true;

        while (inLoansMenu)
        {
            Console.Clear();

            Console.WriteLine("========== Loans Menu ==========");
            Console.WriteLine();
            Console.WriteLine("1. Create Loan");
            Console.WriteLine("2. List Loans");
            Console.WriteLine("3. View Loan Detail");
            Console.WriteLine("4. Return Return");
            Console.WriteLine("5. Delete Loan");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    CreateLoan();
                    break;
                case 2:
                    ListLoansMenu();
                    break;
                case 3:
                    ViewLoanDetail();
                    break;
                case 4:
                    RegisterReturn();
                    break;
                case 5:
                    DeleteLoan();
                    break;
                case 0:
                    inLoansMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void CreateLoan()
    {
        Console.Clear();

        Console.WriteLine("Create Loan");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating loan creation...");
        Console.WriteLine();
        Console.WriteLine("Validations required:");
        Console.WriteLine("- User must exist");
        Console.WriteLine("- User must be active");
        Console.WriteLine("- Book must exist");
        Console.WriteLine("- Book must be available");
        Console.WriteLine("- Optional: maximum active loans per user");

        WaitForUser();
    }

    static void ListLoansMenu()
    {
        bool inListMenu = true;

        while (inListMenu)
        {
            Console.Clear();

            Console.WriteLine("List Loans");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. List All");
            Console.WriteLine("2. List Active");
            Console.WriteLine("3. List Closed");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    ListLoansAll();
                    break;
                case 2:
                    ListLoansActive();
                    break;
                case 3:
                    ListLoansClosed();
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

    static void ListLoansAll()
    {
        Console.Clear();

        Console.WriteLine("Listing All Loans");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating list of all loans.");

        WaitForUser();
    }

    static void ListLoansActive()
    {
        Console.Clear();

        Console.WriteLine("Listing Active Loans");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating list of active loans.");

        WaitForUser();
    }

    static void ListLoansClosed()
    {
        Console.Clear();

        Console.WriteLine("Listing Closed Loans");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating list of returned loans.");

        WaitForUser();
    }

    static void ViewLoanDetail()
    {
        Console.Clear();

        Console.WriteLine("View Loan Detail");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating loan lookup by ID.");

        WaitForUser();
    }

    static void RegisterReturn()
    {
        Console.Clear();

        Console.WriteLine("Register Return");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating return process.");
        Console.WriteLine();
        Console.WriteLine("Expected system actions:");
        Console.WriteLine("- Mark loan as returned");
        Console.WriteLine("- Mark book as available");

        WaitForUser();
    }

    static void DeleteLoan()
    {
        Console.Clear();

        Console.WriteLine("Delete Loan");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Suggested rules:");
        Console.WriteLine("- Allow deletion only if loan is closed");
        Console.WriteLine("- If deleting active loan, return book automatically");

        WaitForUser();
    }

    static void ShowSearchAndReportsMenu()
    {
        bool inSearchMenu = true;

        while (inSearchMenu)
        {
            Console.Clear();

            Console.WriteLine("========== Search and Reports =========");
            Console.WriteLine("1. Search Books");
            Console.WriteLine("2. Search Users");
            Console.WriteLine("3. Reports");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    SearchBook();
                    break;
                case 2:
                    SearchUser();
                    break;
                case 3:
                    ShowReportsMenu();
                    break;
                case 0:
                    inSearchMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void SearchBook()
    {
        Console.Clear();

        Console.WriteLine("Search Book");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Available search filters:");
        Console.WriteLine("- By Title");
        Console.WriteLine("- By Author");
        Console.WriteLine("- By ISBN / ID");
        Console.WriteLine("- By Category");

        Console.WriteLine();
        Console.WriteLine("Simulating book search");

        WaitForUser();
    }

    static void SearchUser()
    {
        Console.Clear();

        Console.WriteLine("Search User");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Available search filters:");
        Console.WriteLine("- By Name");
        Console.WriteLine("- By ID / Document");

        Console.WriteLine();
        Console.WriteLine("Simulating user search.");

        WaitForUser();
    }

    static void ShowReportsMenu()
    {
        bool inReportsMenu = true;

        while (inReportsMenu)
        {
            Console.Clear();

            Console.WriteLine("========== Reports ==========");
            Console.WriteLine("1. Loans by User");
            Console.WriteLine("2. Loans by Book");
            Console.WriteLine("3. Overdue Loans");
            Console.WriteLine("4. System Summary");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    ReportByUser();
                    break;
                case 2:
                    ReportByBook();
                    break;
                case 3:
                    ReportOverdue();
                    break;
                case 4:
                    ReportSummary();
                    break;
                case 0:
                    inReportsMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void ReportByUser()
    {
        Console.Clear();

        Console.WriteLine("Report: Loans by User");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating report generation.");

        WaitForUser();
    }

    static void ReportByBook()
    {
        Console.Clear();

        Console.WriteLine("Report: Loans by Book");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating report generation.");

        WaitForUser();
    }

    static void ReportOverdue()
    {
        Console.Clear();

        Console.WriteLine("Report: Overdue Loans");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating report generation.");

        WaitForUser();
    }

    static void ReportSummary()
    {
        Console.Clear();

        Console.WriteLine("System Summary Report");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating systemsummary:");
        Console.WriteLine("- Total books");
        Console.WriteLine("- Available Books");
        Console.WriteLine("- Borrowed Books");

        WaitForUser();
    }

    static void ShowPersistenceMenu()
    {
        bool inPersistenceMenu = true;

        while (inPersistenceMenu)
        {
            Console.Clear();

            Console.WriteLine("========== Data MANAGEMENT==========");
            Console.WriteLine("1. Save Data");
            Console.WriteLine("2. Load Data");
            Console.WriteLine("3. Reset Data");
            Console.WriteLine("0. Back");
            Console.WriteLine();
            Console.Write("Select an option: ");

            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    SaveData();
                    break;
                case 2:
                    LoadData();
                    break;
                case 3:
                    ResetData();
                    break;
                case 0:
                    inPersistenceMenu = false;
                    break;
                default:
                    ShowInvalidOptionMessage();
                    WaitForUser();
                    break;
            }
        }
    }

    static void SaveData()
    {
        Console.Clear();

        Console.WriteLine("Save Data");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating saving data:");
        Console.WriteLine("- Books");
        Console.WriteLine("- Users");
        Console.WriteLine("- Loans");

        WaitForUser();
    }

    static void LoadData()
    {
        Console.Clear();

        Console.WriteLine("Load Data");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Simulating loading data:");
        Console.WriteLine("- Books");
        Console.WriteLine("- Users");
        Console.WriteLine("- Loans");

        WaitForUser();
    }

    static void ResetData()
    {
        Console.Clear();

        Console.WriteLine("Reset All Data");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("This action will remove all stored data.");
        Console.WriteLine();

        if (ConfirmResetData())
        {
            Console.WriteLine("All system data has been reset (simulation).");
        }
        else
        {
            Console.WriteLine("Operation cancelled.");
        }

        WaitForUser();
    }

    static bool ConfirmResetData()
    {
        Console.Write("Are you sure you want to reset all data? (Y/N): ");

        string? input = Console.ReadLine().ToUpper();

        while (input != "Y" && input != "N")
        {
            Console.Write("Please enter Y or N: ");
            input = Console.ReadLine().ToUpper();
        }

        return input == "Y";
    }
}
