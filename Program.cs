// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

string swirlBase = "https://swirlyeg.com/search?page=1&q=";
string tapsBase = "https://tapsgames.com/search?page=1&q=";
string cbGamesBase = "https://commonboxgames.com/search?page=1&q=";
string prismaBase = "https://www.prismatcg.com/store/search/";
bool contFlag = true;

while (contFlag == true)
{
    Console.WriteLine("Please enter the name of the card you wish to search");
    string userQuery = Console.ReadLine();
    if (userQuery == null)
    {
        userQuery = " ";
    }
    string swirlQuery = swirlBase + "*" + userQuery + "*";
    string tapsQuery = tapsBase + "*" + userQuery + "*";
    string cbGamesQuery = cbGamesBase + "*" + userQuery + "*";
    string prismaQuery = prismaBase + userQuery;

    try
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = swirlQuery,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
    try
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = tapsQuery,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
    try
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = cbGamesQuery,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
    try
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = prismaQuery,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }

    Console.WriteLine("Would you like to search another card? y/n");
    string contString = Console.ReadLine();
    if (contString == "y" | contString == "yes" | contString == "Y" | contString == "YES")
        contFlag = true;
    else contFlag = false;
}

