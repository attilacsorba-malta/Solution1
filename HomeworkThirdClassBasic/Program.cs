//namespace HomeworkThirdClassBasic
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Homework third class Task 1

//            int[] arrayOfIntegers = new int[8];
//        Random randomIntValue = new Random();

//            for (int i = 0; i<arrayOfIntegers.Length; i++)
//            {
//                arrayOfIntegers[i] = randomIntValue.Next(1, 101);
//                Console.WriteLine(arrayOfIntegers[i]);
//            }

//    string result = "";

//            for (int i = 0;i<arrayOfIntegers.Length;i++)
//            {
//                result = result + arrayOfIntegers[i] + ", ";
//            }

//Console.WriteLine(result);


//int j = 0;
//string result1 = "";

//while (j < arrayOfIntegers.Length)
//{
//    result1 = result1 + arrayOfIntegers[j] + ", ";
//    j++;
//}

//Console.WriteLine(result1);

//string result2 = "";

//foreach (int memberOfArray in arrayOfIntegers)
//{
//    result2 = result2 + memberOfArray + ", ";
//}

//Console.WriteLine(result2);

////*************************************************************
////Homework third class Task 2

//            int[] arrayOfIntegers = new int[6];

//for (int i = 0; i < arrayOfIntegers.Length; i++)
//{
//    int userInput = 0;
//    Console.WriteLine($"Enter integer no. {i + 1}:");
//    userInput = Convert.ToInt16(Console.ReadLine());

//    arrayOfIntegers[i] = userInput;
//}

//int summ = 0;

//foreach (int memberOfArray in arrayOfIntegers)
//{
//    int leftOver = memberOfArray % 2;

//    if (leftOver == 0)
//    {
//        summ = summ + memberOfArray;

//    }
//}


//Console.WriteLine($"The result is: {summ}");

////*************************************************************
////Homework third class Task 3

//            int[] arrayOfIntegers = new int[100];

//Random randomIntValue = new Random();

//for (int i = 0; i < arrayOfIntegers.Length; i++)
//{
//    arrayOfIntegers[i] = randomIntValue.Next(1, 101);
//    Console.WriteLine(arrayOfIntegers[i]);
//}

//int summ = 0;

//foreach (int memberOfArray in arrayOfIntegers)
//{
//    int leftOver = memberOfArray % 2;

//    if (leftOver == 0)
//    {
//        summ = summ + memberOfArray;

//    }
//}

//Console.WriteLine($"The result is: {summ}");


////*************************************************************
////Homework third class Task 4

//            string[] studentsG1 = { "Milan", "Biljana", "Vitomir", "Attila", "Dalibor" };
//string[] studentsG2 = { "David", "Miroslav", "Igor", "Marko", "Nikola" };

//Console.WriteLine("Enter student group:");
//int userInput = int.Parse(Console.ReadLine());

//if (userInput == 1)
//{
//    for (int i = 0; i < studentsG1.Length; i++)
//        Console.WriteLine(studentsG1[i]);
//}

//else if (userInput == 2)
//{
//    for (int j = 0; j < studentsG2.Length; j++)
//        Console.WriteLine(studentsG2[j]);
//}

//else Console.WriteLine("Input number 1 or 2!");

////*************************************************************
////Homework third class Task 5

//            int[] arrayOfIntegers = new int[20];
//Random randomIntValue = new Random();

//for (int i = 0; i < arrayOfIntegers.Length; i++)
//{
//    arrayOfIntegers[i] = randomIntValue.Next(1, 101);
//    Console.WriteLine(arrayOfIntegers[i]);
//}

//var duplicates = arrayOfIntegers.GroupBy(numberValue => numberValue)
//                    .Where(numberOccurrence => numberOccurrence.Count() > 1)
//                    .ToDictionary(g => g.Key);

//Console.WriteLine("Duplicates:");

//foreach (var duplicatedNumber in duplicates)
//{
//    Console.WriteLine(duplicatedNumber.Key);
//}

////*************************************************************
////Homework third class Task 6

//int[] arrayOfIntegers = new int[20];
//Random randomIntValue = new Random();

//for (int i = 0; i < arrayOfIntegers.Length; i++)
//{
//    arrayOfIntegers[i] = randomIntValue.Next(1, 101);

//}

//Console.WriteLine(string.Join(", ", arrayOfIntegers));

//Console.WriteLine("Input number between 0 and 101!");
//int userInput = int.Parse(Console.ReadLine());

//bool found = false;

//for (int i = 0; i < arrayOfIntegers.Length; i++)
//{
//    if (arrayOfIntegers[i] == userInput)
//    {
//        found = true;
//        break;
//    }

//}

//if (found == true)
//{
//    Console.WriteLine($"The number {userInput} is an element of the array.");
//}

//else
//{
//    Console.WriteLine($"The number {userInput} is not an element of the array.");
//}

////*************************************************************
////Homework third class Task 7

//string[] msgArr = { "Send data", "Message arr", "Calculate data", "SEDC Code Academy C# basic", "Play" };

//int stringLenght = 0;
//int stringIndex = 0;

//for (int i = 0; i < msgArr.Length; i++)
//{
//    if (msgArr[i].Length > stringLenght)
//    {
//        stringLenght = msgArr[i].Length;
//        stringIndex = i;
//    }
//}

//Console.WriteLine($"The longest word:: {msgArr[stringIndex]}");
//Console.WriteLine($"Letters count: {stringLenght}");

//            //*************************************************************
//            //Homework third class Task 8
//            /

//            var watch = new System.Diagnostics.Stopwatch();
//watch.Start();

//int[,] table = new int[5, 4];
//Random randomIntValue = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        table[i, j] = randomIntValue.Next(1, 101);

//    }
//}

//int numberOfRows = table.GetLength(0);
//int numberOfColumns = table.GetLength(1);

//int numberOfValues = numberOfRows * numberOfColumns;

//Console.WriteLine($"Number of values: {numberOfValues}.");

//int sum = 0;
//int min = table[1, 1];
//int max = 0;


//for (int i = 0; i < numberOfRows; i++)
//{
//    for (int j = 0; j < numberOfColumns; j++)
//    {
//        sum = sum + table[i, j];

//        if (min > table[i, j])
//        {
//            min = table[i, j];
//        }

//        if (max < table[i, j])
//        {
//            max = table[i, j];
//        }

//    }
//}

//Console.WriteLine($"Sum of all values: {sum}.");
//Console.WriteLine($"Minimum value is: {min}.");
//Console.WriteLine($"Maximum value is: {max}.");

//float average = (float)sum / numberOfValues;
//Console.WriteLine($"Average value is: {average}.");

//int x = 0;

//while (x < numberOfRows)
//{
//    int y = 0;
//    while (y < numberOfColumns)
//    {
//        Console.WriteLine($"{table[x, y]}");
//        y++;
//    }
//    x++;
//}

//for (int i = 0; i < numberOfRows; i++)
//{
//    string printingFormatedArray = "";
//    for (int j = 0; j < numberOfColumns; j++)
//    {
//        printingFormatedArray += table[i, j];
//        if (j < numberOfColumns - 1)
//        {
//            printingFormatedArray += ", ";
//        }
//    }

//    Console.WriteLine(printingFormatedArray);
//}

//watch.Stop();
//Console.WriteLine("Execution Time: " +
//watch.ElapsedMilliseconds + " ms");

//            //*************************************************************
//            //Homework third class Task 9
//            / implemented in task 8
//            /

//            //*************************************************************
//            //Homework third class Task 10
//            /

//            Console.WriteLine("This application is generating two dimensional arrays: \r\n[5,3], [50, 30], [500, 300], [5000, 3000],[50000, 3000] etc.\r\nPlease enter the limit for number of rows (5, 50, 500, etc):");
//            int limitForNumberOfRows = int.Parse(Console.ReadLine());

//            int limitForNumberOfColumns = 3;

//            for (int m = 5; m <= limitForNumberOfRows; m = m * 10)
//            {
//                int[,] table = new int[m, limitForNumberOfColumns];
//                Random randomIntValue = new Random();

//                for (int i = 0; i < m; i++)
//                {
//                    for (int j = 0; j < limitForNumberOfColumns; j++)
//                    {
//                        table[i, j] = randomIntValue.Next(1, 101);
//                    }
//                }

//                int numberOfRows = table.GetLength(0);
//                int numberOfColumns = table.GetLength(1);

//                if (m < 51)
//                {
//                    for (int i = 0; i < numberOfRows; i++)
//                    {
//                        string printingFormatedArray = "";
//                        for (int j = 0; j < numberOfColumns; j++)
//                        {
//                            printingFormatedArray += table[i, j];
//                            if (j < numberOfColumns - 1)
//                            {
//                                printingFormatedArray += ", ";
//                            }
//                        }
//                        Console.WriteLine(printingFormatedArray);
//                    }
//                    Console.WriteLine("******************************************************");
//                }
//                else
//                {
//                    Console.WriteLine($"Array [{m}, {limitForNumberOfColumns}] is too big for display.");
//                    Console.WriteLine("******************************************************");
//                }
//                limitForNumberOfColumns = limitForNumberOfColumns * 10;
//            }
//        }
//    }
//}