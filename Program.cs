using System.Diagnostics;

// Local Card Searcher ; Version: 3.1
// 2023-06-30
// Last Edited 2023-10-10
// Created By James Ginther
// Input: String
// Processing: Adds user's String to URL Strings to make valid search queries.
// Output: Opens URLs in user's defeault browser.

//Base URLs to use as queries
string swirlBase = "https://swirlyeg.com/search?page=1&q=";
string tapsBase = "https://tapsgames.com/search?page=1&q=";
string cbGamesBase = "https://commonboxgames.com/search?page=1&q=";
string prismaBase = "https://www.prismatcg.com/store/search/";
string hpwBase = "https://hpwcards.com/search?page=1&q=";
string eclipseBase = "https://eclipsegames.ca/search?type=product&options%5Bprefix%5D=last&q=";
bool contFlag = true;

//Authorial Credit Text
Console.WriteLine("Local Card Searcher ; Version 3.2");
Console.WriteLine("Created by James Ginther, james.ginther01@gmail.com, Github: GintTech");
Console.WriteLine("2024-02-24");
Console.WriteLine("");

// Flag doesn't change anymore
// Request user input, if it's not something that quits the program append it to the base strings and open the result strings as links
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
    string hpwQuery = hpwBase + "*" + userQuery + "*";
    string eclipseQuery = eclipseBase + "*" + userQuery + "*";

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
    try
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = hpwQuery,
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
            FileName = eclipseQuery,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}