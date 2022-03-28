// Author:      Caden Gay
// Date:        03/27/2022
// Assignment:  CSCI 1250 Lab 6
// Desc.:       4 Methods

ShowCharacter();

CalculateRetail();

Temperature();

IsPrime();

static void ShowCharacter()
{
    string city;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("***For this method, you will input a city and an integer.");
    Console.WriteLine("***The method will show you the character at the integer you enter, in the city you enter.");
    Console.WriteLine();
    Console.WriteLine("***Please enter a city.");
    Console.WriteLine();
    city = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("***Please enter an integer.");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    char Letter = city[num - 1];
    Console.WriteLine($"***In {city}, the character at {num} is {Letter}");
}

static void CalculateRetail()
{
    string? iName;
    decimal wsPrice;
    decimal retPrice;
    decimal markUp;
    decimal markUpPerc;
    decimal markUpAmount;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("***You will now enter a grocery item and it's wholesale cost.");
    Console.WriteLine("***This method will take the item and it's wholesale cost, and return the retail cost.");
    Console.WriteLine();
    Console.WriteLine("***Please enter the item's name.");
    iName = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("***Please enter the item's wholesale cost.");
    Console.Write("$");
    wsPrice = decimal.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("***Please enter the markup percentage.");
    markUp = decimal.Parse(Console.ReadLine());
    Console.WriteLine();

    markUpPerc = (markUp / 100);
    markUpAmount = wsPrice * markUpPerc;
    retPrice = wsPrice + markUpAmount;

    decimal.Round(retPrice, 2);

    Console.WriteLine($"***The {iName} is bought for ${wsPrice} and sold for ${retPrice}.");
}

static void Temperature()
{
    float fahr;
    float cel;
    float formula = .555556F;
    float outputCel;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("***Please enter an integer that represents a temperature in degrees Fahrenheit.");
    //freedom units
    fahr = float.Parse(Console.ReadLine());
    Console.WriteLine();

    //conquered units
    float celMath = fahr-32;
    cel = (formula) * celMath;
    outputCel = MathF.Round(cel, 2);
    Console.WriteLine($"***You entered {fahr}F.  This is equal to {outputCel}C.");
    Console.WriteLine();

    float chartF = 80F;
    float chartC;
    float chartMath;
    float celOutput;

    while(chartF > 79 && chartF < 101)
    {
        chartMath = chartF-32;
        chartC = formula * chartMath;
        celOutput = MathF.Round(chartC, 2);
        Console.WriteLine($"{chartF}F is equal to {celOutput}C");
        chartF ++;
    }
}

static void IsPrime()
{
    Console.WriteLine("***This method will check the number you enter and determine if it is prime.");
    Console.Write("***Please enter a number. ");
    int testNum = Convert.ToInt32(Console.ReadLine());
}