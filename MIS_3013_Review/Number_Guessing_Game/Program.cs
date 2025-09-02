
//write a loop to let them keep playing if they want

for(int i = 0; i < int.MaxValue; i++)
{  

    Console.WriteLine("Please input the lower bound value:");
    string answer = Console.ReadLine();
    int lowerBound = int.Parse(answer);


    Console.WriteLine("Please input the upper bound value:");
    string answer2 = Console.ReadLine();
    int upperBound = int.Parse(answer2);


    //data_type variable_name = value;
    Random r = new Random();

    //range1 = int(console.writeline("Give me a minimum range: "))
    //range2 = console.writeline("Give me a maximum range: ")

    //min is inclusive, max is exclusive (not included, so need to do +1 to max)
    //var makes rand whatever data type the right side of the = is
    int rand = r.Next(lowerBound,upperBound + 1);

    int guess;
    int count = 0;

    do
    {
       Console.WriteLine($"Please guess a number between {lowerBound} and {upperBound}: ");
       string userGuess = Console.ReadLine();
        guess = Convert.ToInt32(userGuess);
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

    }while (guess != rand);

    Console.WriteLine("Do you want to try your luck again? yes or no?");
    string answer3 = Console.ReadLine().ToLower();

    if (answer3 == "no")
    {
        break;
    }

}
Console.WriteLine("Thanks for playing!");




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
