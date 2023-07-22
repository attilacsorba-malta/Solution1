//**************************************************************************************************
////Homework1

Console.WriteLine("Imput number of apples:");

int n = int.Parse(Console.ReadLine());

Console.WriteLine("Input the number of apples which can fit in a crate of yours:");

int m = int.Parse(Console.ReadLine());

int numberOfCratesFull = n / m;

int restOfApples = n % m;

if (restOfApples == 0)
{
    Console.WriteLine($"You need {numberOfCratesFull} crates!");
}

else
{
    numberOfCratesFull += 1;
    Console.WriteLine($"You need {numberOfCratesFull} crates!");
}

////*******************************************************************************

////Homework2

Console.WriteLine("Input first number:");

string userInput1 = Console.ReadLine();

float firstNumber = 0;

bool firstNumberCheck = float.TryParse(userInput1, out firstNumber);

Console.WriteLine("Input second number:");

string userInput2 = Console.ReadLine();

float secondNumber = 0;

bool secondNumberCheck = float.TryParse(userInput2, out secondNumber);

if (firstNumber > secondNumber)
{
    Console.WriteLine($"The bigger number is: {firstNumber}!");
}

else if (firstNumber == secondNumber)
{
    Console.WriteLine("The numbers are same!");
}

else
{
    Console.WriteLine($"The bigger number is: {secondNumber}");
}

////****************************************************************************************
///

////Homework3

Console.WriteLine("Please enter what is behind the door number: 1, 2, 3!");

string userInput = Console.ReadLine();
int doorNumber;

bool userInputParse = int.TryParse(userInput, out doorNumber);

if (doorNumber == 1)
{
    Console.WriteLine("You got a new car!");
}

else if (doorNumber == 2)
{
    Console.WriteLine("You got a new plane!");
}

else if (doorNumber == 3)
{
    Console.WriteLine("You got a new bike!");
}

else
{
    Console.WriteLine("Enter number from 1 till 3!");
}

////**************************************************************************

////Homework4

Console.WriteLine("Please enter what is behind the door number: 1, 2, 3!");

string userInput = Console.ReadLine();
int doorNumber;

bool userInputParse = int.TryParse(userInput, out doorNumber);

switch (doorNumber)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;

    case 2:

        Console.WriteLine("You got a new plane!");
        break;

    case 3:

        Console.WriteLine("You got a new bike!");
        break;

    default:

        Console.WriteLine("Enter number from 1 till 3!");
        break;
}
////*******************************************************************************

////Homework5

Console.WriteLine("Enter height in cm:");

string userInput = Console.ReadLine();
int personsHeight;
bool personsHeightCheck = int.TryParse(userInput, out personsHeight);

if (personsHeightCheck == false || personsHeight <= 0)
{
    Console.WriteLine("Please input positive integer value bigger than 0 for height in cm!");
}

else
{
    if (personsHeight <= 160)
    {
        Console.WriteLine("This person is a short person.");
    }

    else if (personsHeight >= 181)
    {
        Console.WriteLine("This person is a tall person.");
    }

    else
    {
        Console.WriteLine("This person is an average person.");
    }
}
////*****************************************************************

////Homework6



Console.WriteLine("Input first number:");
string userInput1 = Console.ReadLine();

float firstNumber;

bool firstNumberCheck = float.TryParse(userInput1, out firstNumber);

Console.WriteLine("Input second number:");
string userInput2 = Console.ReadLine();

float secondNumber;

bool secondNumberCheck = float.TryParse(userInput2, out secondNumber);

Console.WriteLine("Input third number:");
string userInput3 = Console.ReadLine();

float thirdNumber;

bool thirdNumberCheck = float.TryParse(userInput3, out thirdNumber);

if (firstNumber < secondNumber)
{
    if (secondNumber < thirdNumber)
    {
        Console.WriteLine($"{thirdNumber} is the greatest.");
    }
    else
    {
        Console.WriteLine($"{secondNumber} is the greatest.");
    }
}

else if (firstNumber < thirdNumber)
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine($"{secondNumber} is the greatest.");
    }
    else
    {
        Console.WriteLine($"{thirdNumber} is the greatest.");
    }

}

else
{
    Console.WriteLine($"{firstNumber} is the greatest.");
}


if (firstNumber == secondNumber && secondNumber == thirdNumber)
{
    Console.WriteLine("The numbers are equal.");
}
//////*********************************************************************************

////Homework7

Console.WriteLine("Enter first number:");

int firstNumber;

bool userInput1 = int.TryParse(Console.ReadLine(), out firstNumber);

Console.WriteLine("Enter second number:");

int secondNumber;

bool userInput2 = int.TryParse(Console.ReadLine(), out secondNumber);

int container = firstNumber;
firstNumber = secondNumber;
secondNumber = container;

Console.WriteLine($"First number: {firstNumber}");
Console.WriteLine($"Second number: {secondNumber}");
////***************************************************************************************

//Homework8

Console.WriteLine("Enter firs number:");

float firstNumber;

bool firstNumberCheck = float.TryParse(Console.ReadLine(), out firstNumber);

Console.WriteLine("Enter firs number:");

float secondNumber;

bool secondNumberCheck = float.TryParse(Console.ReadLine(), out secondNumber);

Console.WriteLine("Enter an operator (+, -, /, *):");
string operatorUserChoice = Console.ReadLine();

switch (operatorUserChoice)
{
    case ("+"):
        float resultPlus = firstNumber + secondNumber;
        Console.WriteLine(resultPlus);
        break;

    case ("-"):
        float resultMinus = firstNumber - secondNumber;
        Console.WriteLine(resultMinus);
        break;

    case ("*"):
        float resultMultiply = firstNumber * secondNumber;
        Console.WriteLine(resultMultiply);
        break;

    case ("/"):
        float resultDivision = firstNumber / secondNumber;
        Console.WriteLine(resultDivision);
        break;

}













