string verifyContinuation = "YES";
do
{
    Console.Clear();
    Console.Write("Enter the method you would like to run (1, 2, 3 or 4): ");
    string userInput = Console.ReadLine().Trim();
    Console.Clear();


    switch (userInput)
    {
        case "1":
            Console.Write("Input a string: ");
            var inputString = Console.ReadLine().Trim();

            Console.Write("Input the character number would you like to see (Positive Integer): ");
            int inputCharacterNumber = Int32.Parse(Console.ReadLine().Trim());

            Console.WriteLine($"The character in spot {inputCharacterNumber} is: {ShowCharacter(inputString, inputCharacterNumber)}");


            // Method "WillContinue" is used to ask the user if they want to test another method
            verifyContinuation = WillContinue();

            break;


        case "2":
            Console.Write("Enter the wholesale cost of the item: $");
            double wholeSaleCost = Double.Parse(Console.ReadLine().Trim());

            Console.Write("Enter the markup percentage: ");
            double markupPercentage = Double.Parse(Console.ReadLine().Trim());
            CalculateRetail(wholeSaleCost, markupPercentage);


            // Method "WillContinue" is used to ask the user if they want to test another method
            verifyContinuation = WillContinue();
            break;


        case "3":
            for (int i = 80; i <= 100; i++)
            {
                Celcius(i);
            }


            // Method "WillContinue" is used to ask the user if they want to test another method
            verifyContinuation = WillContinue();
            break;


        case "4":
            Console.Write("Insert a positive integer: ");
            int positiveInteger = Int32.Parse(Console.ReadLine().Trim());

            Console.WriteLine($"Is prime: {IsPrime(positiveInteger)}");

            // Method "WillContinue" is used to ask the user if they want to test another method
            verifyContinuation = WillContinue();
            break;


        default:
            Console.WriteLine("Can you read....");
            break;
    }
} while (verifyContinuation == "YES");




////////////////////////////////////////////////////////////////////////
///                             Methods                              ///
////////////////////////////////////////////////////////////////////////

#region LabMethods

#region Method1

static char ShowCharacter(string inputString, int inputCharacterNumber)
{
    char selectedCharacter = inputString[inputCharacterNumber - 1];
    return selectedCharacter;
}

#endregion


#region Method2

static void CalculateRetail(double wholeSaleCost, double markupPercentage)
{
    var total = wholeSaleCost * (1.0 + (markupPercentage / 100));
    string totalAsString = Convert.ToString(total);
    Console.WriteLine($"The retail price of your item is {total.ToString("C")}");
}

#endregion


#region Method3
static void Celcius(double tempFahrenheit)
{
    if (tempFahrenheit < 100)
    {
        double tempCelcius = (0.5556) * (tempFahrenheit - 32);
        Console.WriteLine($"{tempFahrenheit}      --      {Math.Round(tempCelcius, 2)}");
    }
    else
    {
        double tempCelcius = (0.5556) * (tempFahrenheit - 32);
        Console.WriteLine($"{tempFahrenheit}     --      {Math.Round(tempCelcius, 2)}");
    }
}
#endregion


#region Method4
static string IsPrime(int inputNumber)
{
    bool isPrime = true;

    if (inputNumber == 2)
    {
        isPrime = true;
        return Convert.ToString(isPrime);
    }
    else if (inputNumber == 1)
    {
        isPrime = false;
        return Convert.ToString(isPrime);
    }
    else
    {
        for (int i = 2; i < inputNumber; i++)
        {
            int remainder = 1;
            if (remainder > 0)
            {
                remainder = (inputNumber % i);
                if (remainder > 0)
                {
                    isPrime = true;
                }
                else
                {
                    isPrime = false;
                    return Convert.ToString(isPrime);
                }
            }
            else
            {
                isPrime = false;
            }
        }
        return Convert.ToString(isPrime);
    }

}
#endregion

#endregion




#region OtherMethods

static string WillContinue()
{
    Console.Write("\n\nWould You like to test another method (Yes or No): ");
    var willContinue = Console.ReadLine().Trim().ToUpper();
    if (willContinue == "YES" || willContinue == "NO")
    {
        return willContinue;
    }
    else
    {
        while (willContinue != "YES" && willContinue != "NO")
        {
            Console.WriteLine("Invalid Input");
            Console.Write("Would you like to try another method (Yes or No): ");
            willContinue = Console.ReadLine().Trim().ToUpper();
        }
        return willContinue;
    }
}
#endregion