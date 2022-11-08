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

  Items[index] = userItems;
  index++;

    if (userItems.ToLower().Trim() != "exit")     // this shoud be inside while case loop if mesage should show each time user makes an input
    {
        Console.WriteLine("You typed a word found in the datatbase.");
    }
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