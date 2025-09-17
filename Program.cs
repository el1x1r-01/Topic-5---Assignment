namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programNumber;

            Console.WriteLine("Which program would you like to run? (Part 1 / Part 2 / Part 3)");
            programNumber = Console.ReadLine();

            Console.WriteLine("");

            if (programNumber.ToLower() == "part 1" || programNumber == "1")
            {
                Part1();
            }

            else if (programNumber.ToLower() == "part 2" || programNumber == "2")
            {
                Part2();
            }

            else if (programNumber.ToLower() == "part 3" || programNumber == "3")
            {
                Part3();
            }

            Console.ReadLine();
        }

        public static void Part1()
        {
            int planet;
            double earthWeight, planetWeight;

            Console.WriteLine("Welcome, Julio Cesar Chavez Mark VII.");
            Console.WriteLine("");

            Console.Write("Please enter your current Earth weight: ");
            double.TryParse(Console.ReadLine(), out earthWeight);

            Console.WriteLine("");
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("");
            Console.WriteLine("\t 1. Venus \t 2. Mars \t 3. Jupiter");
            Console.WriteLine("\t 4. Saturn \t 5. Uranus \t 6. Neptune");

            Console.WriteLine("");
            Console.WriteLine("Which planet are you visiting?");
            Int32.TryParse(Console.ReadLine(), out planet);

            Console.WriteLine("");

            if (planet == 1)
            {
                planetWeight = Math.Round((earthWeight * 0.78), 1);

                Console.WriteLine("Your weight on Venus would be " + planetWeight + " lbs.");
            }

            else if (planet == 2)
            {
                planetWeight = Math.Round((earthWeight * 0.39), 1);

                Console.WriteLine("Your weight on Mars would be " + planetWeight + " lbs.");
            }

            else if (planet == 3)
            {
                planetWeight = Math.Round((earthWeight * 2.65), 1);

                Console.WriteLine("Your weight on Jupiter would be " + planetWeight + " lbs.");
            }

            else if (planet == 4)
            {
                planetWeight = Math.Round((earthWeight * 1.17), 1);

                Console.WriteLine("Your weight on Saturn would be " + planetWeight + " lbs.");
            }

            else if (planet == 5)
            {
                planetWeight = Math.Round((earthWeight * 1.05), 1);

                Console.WriteLine("Your weight on Uranus would be " + planetWeight + " lbs.");
            }

            else if (planet == 6)
            {
                planetWeight = Math.Round((earthWeight * 1.23), 1);

                Console.WriteLine("Your weight on Neptune would be " + planetWeight + " lbs.");
            }

            else
            {
                Console.WriteLine("That is not a valid planet.");
            }
        }

        public static void Part2()
        {
            double number1, number2, answer;
            string mathOperator;

            Console.Write("Enter your first number: ");
            double.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("");
            Console.WriteLine("Enter your mathematic operator:");
            Console.WriteLine("");
            Console.WriteLine("\t Addition (+) \t Subtraction (-) \t Multiplication (*)");
            Console.WriteLine("\t Division (/) \t Square (²)");
            mathOperator = Console.ReadLine();

            Console.WriteLine("");

            if (mathOperator == "+" || mathOperator.ToLower() == "addition")
            {
                Console.WriteLine("");
                Console.Write("Enter your second number: ");
                double.TryParse(Console.ReadLine(), out number2);

                answer = (number1 + number2);

                Console.WriteLine(number1 + " + " + number2 + " = " + answer);
            }

            else if (mathOperator == "-" || mathOperator.ToLower() == "subraction")
            {
                Console.WriteLine("");
                Console.Write("Enter your second number: ");
                double.TryParse(Console.ReadLine(), out number2);

                answer = (number1 - number2);

                Console.WriteLine(number1 + " - " + number2 + " = " + answer);
            }

            else if (mathOperator == "*" || mathOperator.ToLower() == "multiplication")
            {
                Console.WriteLine("");
                Console.Write("Enter your second number: ");
                double.TryParse(Console.ReadLine(), out number2);

                answer = (number1 * number2);

                Console.WriteLine(number1 + " * " + number2 + " = " + answer);
            }

            else if (mathOperator == "/" || mathOperator.ToLower() == "division")
            {
                Console.WriteLine("");
                Console.Write("Enter your second number: ");
                double.TryParse(Console.ReadLine(), out number2);

                answer = (number1 / number2);

                Console.WriteLine(number1 + " / " + number2 + " = " + answer);
            }

            else if (mathOperator == "²" || mathOperator.ToLower() == "square")
            {
                answer = (number1 * number1);

                Console.WriteLine(number1 + "² = " + answer);
            }

            else
            {
                Console.WriteLine("That is not a valid equation.");
            }
        }

        public static void Part3()
        {
            int score, numberAnswer;
            string textAnswer, hogwartsHouse;
            double finalScore;

            score = 0;

            Console.WriteLine("Welcome, Potterhead! Time to test your knowledge...");
            Console.WriteLine("");
            Console.WriteLine("Which Hogwarts house are you earning points for today?");
            hogwartsHouse = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Question 1: How many books are in the Harry Potter series?");
            Int32.TryParse(Console.ReadLine(), out numberAnswer);

            Console.WriteLine("");

            if (numberAnswer == 7)
            {
                Console.WriteLine("Correct! While the Wizarding World universe has expanded, " +
                    "there are 7 books in the original Harry Potter series.");

                score += 1;
            }
            else
            {
                Console.WriteLine("Incorrect. While the Wizarding World universe has expanded, " +
                    "there are 7 books in the original Harry Potter series.");
            }

            Console.WriteLine("");
            Console.WriteLine("Question 2: Finish the quote:");
            Console.WriteLine("");
            Console.WriteLine("\t 'Happiness can be found, even in the darkest of times, if one only remembers to _________________.'");
            textAnswer = Console.ReadLine();

            Console.WriteLine("");

            if (textAnswer.ToLower() == "turn on the light")
            { 
                Console.WriteLine("Correct! This is one of Albus Dumbledore's most famous quotes.");

                score += 1;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer was: 'turn on the light'.");
            }

            Console.WriteLine("");
            Console.WriteLine("Question 3: Which Hogwarts house is J.K. Rowling's favourite?");
            Console.WriteLine("");
            Console.WriteLine("\t a) Gryffindor \t b) Ravenclaw");
            Console.WriteLine("\t c) Hufflepuff \t b) Slytherin");
            textAnswer = Console.ReadLine();

            Console.WriteLine("");

            if (textAnswer.ToLower() == "c" || textAnswer.ToLower() == "c)" || textAnswer.ToLower() == "hufflepuff")
            {
                Console.WriteLine("Correct! The author of the Harry Potter series, J.K. Rowling, revealed that Hufflepuff" +
                    " is her favourite Hogwarts house due to it having produced the least amount of dark wizards.");

                score += 1;
            }
            else
            {
                Console.WriteLine("Incorrect. The author of the Harry Potter series, J.K. Rowling, revealed that Hufflepuff" +
                    " is her favourite Hogwarts house due to it having produced the least amount of dark wizards.");
            }

            Console.WriteLine("");
            finalScore = (score / 6.0);

            if (score > 0)
            {
                Console.WriteLine("Congratulations, you got " + score + " answers correct! That's a score of " 
                    + finalScore.ToString("P") + ". The " + hogwartsHouse + " house has recieved " + (score * 10) + " points!");
            }
            else if (score == 0)
            {
                Console.WriteLine("Wow! You got 0 answers correct! You're a disappointment to the name of " + hogwartsHouse +"!");
            }
            else if (score >= 6)
            {
                Console.WriteLine("A perfect score! 100 points to " + hogwartsHouse + "!");
            }
        }
    }
}
