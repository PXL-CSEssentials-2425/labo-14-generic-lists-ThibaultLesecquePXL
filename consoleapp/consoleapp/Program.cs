using System.Runtime.CompilerServices;
using System.Text;

StringBuilder sb = new StringBuilder();
List<string> namesList = new List<string>();

Console.WriteLine("1.Voeg een naam toe");
Console.WriteLine("2.Toon alle namen");
Console.WriteLine("3.Zoek een naam");
Console.WriteLine("4.Verwijder een naam");
Console.WriteLine("5.Toon het aantal namen");
Console.WriteLine("6.Stoppen");

while (true)
{ 
    Console.Write("\nKies een optie: ");

    switch (Console.ReadLine())
    {
        case "1":
            AddName();
            break;
        case "2":
            ShowNames();
            break;
        case "3":
            SearchName();
            break;
        case "4":
            DeleteName();
            break;
        case "5":
            ShowNamesCount();
            break;
        case "6":
            QuitApplication();
            break;
        default:
            Console.WriteLine("Foutieve input!\n");
            break;
    }
}

void AddName()
{
    Console.Write("Voer een naam in: ");
    string inputName = Console.ReadLine();
    inputName = char.ToUpper(inputName[0]) + inputName.Substring(1).ToLower();

    int nameIndex = namesList.IndexOf(inputName);
    if (nameIndex == -1)
    {
        namesList.Add(inputName);
    }
    else
    {
        Console.WriteLine($"De naam komt al voor in de lijst op plaats {nameIndex}");
    }
}

void ShowNames()
{
    sb.AppendLine("Namen in de lijst: ");
    foreach (string name in namesList)
    {
        sb.AppendLine($"- {name}");
    }
    Console.WriteLine(sb.ToString());
    sb.Clear();
}

void SearchName()
{
    Console.Write("Geef een naam in: ");
    int nameIndex = namesList.IndexOf(Console.ReadLine());
    if (nameIndex == -1)
    {
        Console.WriteLine("De naam komt NIET voor in de lijst!");
    }
    else
    {
        Console.WriteLine($"De naam komt voor in de lijst op plaats {nameIndex}");
    }
}

void DeleteName()
{
    Console.Write("Geef een naam in: ");
    int nameIndex = namesList.IndexOf(Console.ReadLine());
    if (nameIndex == -1)
    {
        Console.WriteLine("De naam komt NIET voor in de lijst!");
    }
    else
    {
        namesList.RemoveAt(nameIndex);
        ShowNames();
    }
}

void ShowNamesCount()
{
    Console.WriteLine($"Er staan momenteel {namesList.Count} namen in de lijst.");
}

void QuitApplication()
{
    Environment.Exit(0);
}