
string folderPath = @"D:\proge";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItems();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine("File " + fileName + " has been created.");
    myShoppingList = GetItems();
    File.WriteAllLines(filePath, myShoppingList);
}




static List<string> GetItems()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else if (userChoice == "exit")
        {
            Console.WriteLine("Bye");
            break;
        }
        else
        {
            Console.WriteLine("Type add or exit");
        }
    }
    return userList;
}


static void ShowItems(List<string>someList)
{ 
    Console.Clear();
    int listLength  = someList.Count;
    Console.WriteLine("You have added " + listLength + " items to your shopping list");

    int i = 1;
    foreach (string item in someList)
    { 
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}