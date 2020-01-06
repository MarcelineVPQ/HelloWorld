using System;

namespace HelloWorld
{
    /*C# Coding Standards and Naming Conventions:
     * https://www.dofactory.com/reference/csharp-coding-standards
     * 
     * Naming Conventions - 
     *  - Class Name use Pascal(CapitalCapital)(ex:ClientActivity)
     * */
    class Program
    /*variables declared here will be available
     * to all the methods in the class Program.
     * */
    {
        //starting point of our program
        /*Naming Conventions
         * Method Name use Pascal(CapitalCapital)(ex:CalculateVale)
         * Method arguments use camel Casing(lowerCapital)(ex:firstNumber)
         * */


        /*Chapter 3 (video 23 ) Constants notes:
         * constants as fields
         * 
         * */
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        //create a constant with your birthday as its value
        const string myBirthday = "30.07.1972";



        static void Main(string[] args)
        {
            /*If a variable is declared in the method
             * then it is only available to use in the method.
             * 
             * Integral numeric types (C# reference)
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
             * 
             * Naming Conventions
             * variables use camel Casing(lowerCapital)(ex:itemCount)
             * 
             * A few Rules:
             *  -avoid using abbreviations (userControl > usrCtl) MAKE IT EASY TO READ!!!!
             *  -don't use numbers at the start of variable names
             *  -avoid the underscore in any name or variable except for the beginning(ex:_firstName)
             * */
            int num1 = 13;
            int num2 = 42;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / num2;

            float f1 = 3.5f;

            //coding standard is to use a lowercase s in string when using it for a variable
            string myName = "Marcy";
            string myMessage = "My name is: " + myName;

            string lowerMessage = myMessage.ToLower();
            string upperMessage = myMessage.ToUpper();

            /*Chapter 3 (Video 19)- conversion-- explicit & implicit & type
             * 
             * */
            double myDouble = 13.37;
            int myInt;
            //explicit conversion(cast double to int)
            myInt = (int)myDouble;

            //implicit conversion (bigger types to smaller types)
            //example 1
            int numIc = 12390532;
            long bigNum = numIc;

            //example 2
            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //type conversion (ex: make a string out of a double or integer)
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();

            /*Chapter 3 (Video 20) - Data Types and Variables
             *  How to Parse
             * 
             * */
            string myParseString = "15";
            string mySecondParseString = "13";
            int parseNum1 = Int32.Parse(myParseString);
            int parseNum2 = Int32.Parse(mySecondParseString);
            int parseResultInt = parseNum1 + parseNum2;

            //Chapter 3 Post Video 20 CHALLANGE
            byte challangeByte = 42;
            sbyte challangeSByte = -42;
            int challangeInt32 = 2147483646;
            uint challangeUInt = 4294967294;
            short challangeShort = -32768;
            long challangeLong = 9223372036854775806;
            ulong challangeULong = 18446744073709551614;
            float challangeFloat = 3.4021f;
            double challangeDouble = 1.79768;
            char challangeChar = 'M';
            bool challangeBool = true;
            string challangeStringOne = "I control text ";
            string challangeStringTwo = "42";
            int parseChallangeStringTwo = Int32.Parse(challangeStringTwo);

            /*Chapter 3 - (Video 23) Constants
             * 
             * Constants are immutable values which are known
             * at compile time and do not change for the life of the program.
             * 
             * */

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
            Console.WriteLine(d1 + " divided by " + num2 + " is: " + sumD);
            Console.WriteLine(myMessage);
            Console.WriteLine(lowerMessage);
            Console.WriteLine(upperMessage);
            //Video 19
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Video 19 ~~~~");
            Console.WriteLine("Explicit - Cast Double to Integer: " + myInt);
            Console.WriteLine("My float to string: " + myFloatString);
            Console.WriteLine("Is the Sun Shining? " + myBoolString);
            //Video 20
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Video 20 ~~~~");
            Console.WriteLine("Parse String Integer Result: " + parseResultInt);
            //CHALLANGE
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ CHALLANGE  ~~~~");
            Console.WriteLine("challangeByte      : " + challangeByte);
            Console.WriteLine("challangeSByte     : " + challangeSByte);
            Console.WriteLine("challangeInt32     : " + challangeInt32);
            Console.WriteLine("challangeUInt      : " + challangeUInt);
            Console.WriteLine("challangeShort     : " + challangeShort);
            Console.WriteLine("challangeLong      : " + challangeLong);
            Console.WriteLine("challangeULong     : " + challangeULong);
            Console.WriteLine("challangeFloat     : " + challangeFloat);
            Console.WriteLine("challangeDouble    : " + challangeDouble);
            Console.WriteLine("challangeChar      : " + challangeChar);
            Console.WriteLine("challangeBool      : " + challangeBool);
            Console.WriteLine("challangeStringOne : " + challangeStringOne);
            Console.WriteLine("challangeStringTwo : " + challangeStringTwo);
            Console.WriteLine("challangeStringTwo Parsed : " + parseChallangeStringTwo);
            //video 23
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Video 23 ~~~~");
            Console.WriteLine("My Birthday will always be: {0}", myBirthday);

            Console.Read();

        }

        /* This program is made, in order to
         * teach how to create my first program
         * labeled Hello World in C Sharp. It is tradition 
         * in programming that your first program type the 
         * words Hello world on the screen through
         * programmatic means.
         * */
    }
}
