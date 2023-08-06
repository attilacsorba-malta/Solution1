using System.Security.Cryptography.X509Certificates;

namespace HWFourthClass
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        ////**********************************************************************************
        ////Class four HW task 1

        Console.WriteLine("Input a string:");

        string input = Console.ReadLine();
        int inputLenght = input.Length;

        int startingIndex = inputLenght - 5;

        if (startingIndex< 0)
        {
            Console.WriteLine(input);
        }

        else
        {
            Console.WriteLine(input.Substring(startingIndex, 5));
        }


//**********************************************************************************
//Class four HW task 2

Console.WriteLine("Input a sentence:");

        string[] sentenceAsArray = Console.ReadLine().Split(' ');

        char[] charactersToRemove = { '.', ',', '!', '?', ':', ';', '\"', '\'' };

        for (int i = 0; i<sentenceAsArray.Length; i++)
        {
            sentenceAsArray[i] = sentenceAsArray[i].TrimEnd(charactersToRemove);
        Console.WriteLine(sentenceAsArray[i]);
        }

    //**********************************************************************************
    //Class four HW task 3
    static void main(string[] args)
        {
            console.writeline("input a number:");
            int input = int.parse(console.readline());

            int result = sumofdigits(input);

            console.writeline(result);

        }
        public static int sumofdigits(int number)
        {
            string numberasstring = number.tostring();

            char[] digitsaschararray = numberasstring.tochararray();

            int result = 0;

            for (int i = 0; i < digitsaschararray.length; i++)
            {
                int digit = int.parse(digitsaschararray[i].tostring());
                result = result + digit;
            }

            return result;
        }





        //**********************************************************************************
        //Class four HW task 4

        static void Main(string[] args)
        {
            Console.WriteLine("Input the date of your birth in DD/MM/YYYY format:");

            string userInput = Console.ReadLine();

            int age = AgeCalculator(userInput);

            Console.WriteLine($"You are {age} years old!");

        }

        public static int AgeCalculator(string dateOfBirth)
        {
            string dayString = dateOfBirth.Substring(0, 2);
            string monthString = dateOfBirth.Substring(3, 2);
            string yearString = dateOfBirth.Substring(6, 4);

            int day = Convert.ToInt32(dayString);
            int month = Convert.ToInt32(monthString);
            int year = Convert.ToInt32(yearString);

            DateTime today = DateTime.Today;

            string todayDay = today.ToString("dd");
            string todayMonth = today.ToString("MM");
            string todayYear = today.ToString("yyyy");

            int todayDayInt = int.Parse(todayDay);
            int todayMonthInt = int.Parse(todayMonth);
            int todayYearInt = int.Parse(todayYear);

            int result = 0;

            if (month == todayMonthInt && day == todayDayInt)
            {
                result = todayYearInt - year;
            }

            if (month == todayMonthInt && day < todayDayInt)
            {
                result = todayYearInt - year;
            }

            if (month == todayMonthInt && day > todayDayInt)
            {
                result = todayYearInt - year - 1;
            }

            else
            {
                if (month > todayMonthInt)
                {
                    result = todayYearInt - year - 1;
                }

                if (month < todayMonthInt)
                {
                    result = todayYearInt - year;
                }
            }
            return result;
        }
    }
}