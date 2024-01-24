﻿// author: Rod Mastria
// topic: Day3 - Lab1

Console.WriteLine("--- Exponent Calculator Game! ---");
Console.WriteLine();

bool continueRun = true;

while (continueRun)
{


    Console.WriteLine("Enter an integer to calculate square and cube values");
    Console.WriteLine();

    int userInt;

    // extra challenge #1 and #3
    while (true)
    {
        userInt = int.Parse(Console.ReadLine());
        if (userInt > 0 && getCube(userInt) <= 2147483647) break; 
        else Console.WriteLine("Please enter positive integer less than 2147483647");
    }

    Console.WriteLine();
    Console.WriteLine("Number    Squared    Cubed");
    Console.WriteLine("======    =======    =====");

    for (int i = 0; i <= userInt; i++)
    {
        Console.WriteLine($"{i}         {getSquare(i)}          {getCube(i)}");
    }

    Console.WriteLine();
    Console.WriteLine("Continue? y/n");
    string userSaid = Console.ReadLine();
        
    if (userSaid.ToLower().Trim().Contains("y"))
    {
        continueRun = true;
    }
    else
    {
        continueRun= false;
    }

}    

static int getSquare(int value)
{
    return value * value;
}

static int getCube(int value)
{
    return value * value * value;
}