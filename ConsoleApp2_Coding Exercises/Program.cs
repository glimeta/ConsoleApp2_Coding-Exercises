// Grace_Coding exercises
// Filling in string array wih user input data, quit command and sorting input data

using System;
using System.Reflection;


int index = 0;
string[] Items = new string[10];


while (true)
{
    Console.Write("Enter item, Write exit to quit: ");
    string userItems = Console.ReadLine();

    if (userItems.ToLower().Trim() == "exit")
    {
        break;
    }

    if (String.IsNullOrEmpty(userItems))  // String refers to input data userItems
    {
        Console.WriteLine("Incorrect Entry. Data missing.");
    }

        Items[index] = userItems;     // This command stacks input data userItems to string array,Items. 
        index++;                      // It uses int index as counter of cell placement in string array,Items.

}



Array.Resize(ref Items, index);
for (int i = 0; i < Items.Length; i++)
{
    
    Console.WriteLine(Items[i]);
}

Array.Sort(Items);
Console.WriteLine("Items sorted");
foreach (string item in Items)
{
    Console.WriteLine(item);
}


Console.WriteLine("Press enter to continue...");

//Reads latest content in Writeline which is just enter, so this closes window and ends program.

Console.ReadLine();