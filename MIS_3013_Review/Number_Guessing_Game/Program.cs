
//write a loop to let them keep playing if they want

for(int i = 0; i < int.MaxValue; i++)
{

    Console.WriteLine("Please input the lower bound value:");
    string answer = Console.ReadLine();
    int lowerBound = 0;

    //way of data validation 
    lowerBound = ValidateInput(answer);

    //if they put in a string rather than an int for the bounds --> data validation 
    //contol KC for comments
    //try
    //{
    //    result = int.Parse(a);
    //}
    //catch(FormatException ex)
    //{
    //    Console.WriteLine("Please enter a number, not a strong :(");
    //}
    //catch(OverflowException ex)
    //{
    //    Console.WriteLine("You're value exceeds the limits");
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine("Something went wrong, please try again.");
    //}

    Console.WriteLine("Please input the upper bound value:");
    string answer2 = Console.ReadLine();
    int upperBound = ValidateInput(answer2, "Invalid input for upper bound, please try again");

    //data_type variable_name = value;
    Random r = new Random();

    //min is inclusive, max is exclusive (not included, so need to do +1 to max)
    //var makes rand whatever data type the right side of the = is
    int rand = r.Next(lowerBound, upperBound + 1);

    int guess;
    int count = 0;

    do
    {
        Console.WriteLine($"Please guess a number between {lowerBound} and {upperBound}: ");
        string userGuess = Console.ReadLine();
        guess = ValidateInput(userGuess, "Invalid input for guess, please try again.");
        count++;

        if (guess == rand)
        {
            Console.WriteLine($"Congrats! You guessed correctly and it only took {count} attempts.");
        }
        else
        {
            if (guess > rand)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you guessed too high!");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sorry, you guessed too low!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"You guessed incorrectly and it only took {count} attempts.");

        }
        //Console.WriteLine($"You guessed {count} times.");

    } while (guess != rand);

    Console.WriteLine("Do you want to try your luck again? yes or no?");
    string answer3 = Console.ReadLine().ToLower();

    if (answer3 == "no")
    {
        break;
    }

}
Console.WriteLine("Thanks for playing!");

//ignore static, int represents the output of the function 
static int ValidateInput(string a, string msg = "Invalid input for lower bound, please try again")
{
    int result;
    while (int.TryParse(a, out result) == false)
    {
        Console.WriteLine(msg);
        a = Console.ReadLine();

    }

    return result;
}




//if (guess == rand)
//{
//    Console.WriteLine($"Congrats! You guessed correctly! You both guessed {rand}.");
//}
//else
//{
//    Console.WriteLine($"You guessed incorrectly. The random number was {rand}.");
//}

//Console.WriteLine($"You guessed {userGuess}");
//Console.WriteLine($"Generated a random number with the value {rand}.");
