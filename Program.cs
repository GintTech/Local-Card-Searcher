using System.Diagnostics;

// Local Card Searcher ; Version: 2.1
// 2023-06-30
// Created By James Ginther
// Input: String
// Processing: Adds user's String to URL Strings to make valid search queries.
// Output: Opens URLs in user's defeault browser.

string swirlBase = "https://swirlyeg.com/search?page=1&q=";
string tapsBase = "https://tapsgames.com/search?page=1&q=";
string cbGamesBase = "https://commonboxgames.com/search?page=1&q=";
string prismaBase = "https://www.prismatcg.com/store/search/";
bool contFlag = true;

Console.WriteLine("Local Card Searcher ; Version 2.1");
Console.WriteLine("Created by James Ginther, james.ginther01@gmail.com, Github: GintTech");
Console.WriteLine("2023-06-30");
Console.WriteLine("");

while (contFlag == true)
{
    Console.WriteLine("Please enter the name of the card you wish to search or q to quit.");
    string userQuery = Console.ReadLine();
    if (userQuery == null)
    {
        userQuery = " ";
    }
    if (userQuery == "q" | userQuery == "Q" | userQuery == "quit" | userQuery == "QUIT" | userQuery == "Quit")
    {
        Environment.Exit(1);
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
}

