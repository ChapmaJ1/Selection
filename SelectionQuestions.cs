using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    public class SelectionQuestions
    {
        public static string BuzzFizz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "Fizzbuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                string numInt = Convert.ToString(num);
                return numInt;
            }
        }
        public static bool IsVowel(string letter)
        {
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsVowel2(string letter)
        {
            bool IsVowel = false;

            List<string> Vowels = new List<string>(5);
            Vowels.Add("a");
            Vowels.Add("e");
            Vowels.Add("i");
            Vowels.Add("o");
            Vowels.Add("u");

            foreach(string a in Vowels)
            {
                if (letter == a)
                {
                    IsVowel = true;
                }
            }

            return IsVowel;
        }
        public static void DiceRoll()
        {
            Random rnd = new Random();
            int rollOne = rnd.Next(1, 7);
            int rollTwo = rnd.Next(1, 7);
            int rollThree = rnd.Next(1, 7);

            if(rollOne == rollTwo && rollTwo == rollThree)
            {
                Console.WriteLine("Three of a kind");
            }
            else if(rollOne == rollTwo || rollTwo == rollThree || rollOne == rollThree)
            {
                Console.WriteLine("You have a pair");
            }
            else
            {
                Console.WriteLine("Sorry you lose");
            }
        }
        public static string AngleType(double angle)
        {
            string type;
            switch (angle)
            {
                case 0 or 180 or 360:
                    type = "straight";
                    break;
                case < 90:
                    type = "acute";
                    break;
                case 90:
                    type = "right";
                    break;
                case < 180:
                    type = "obtuse";
                    break;
                case > 180 and < 360:
                    type = "reflex";
                    break;
                default:
                    type = "invalid";
                    break;
            }
            return type;
        }
        public static void RockPaperScissors()
        {
            Console.WriteLine("Rock, Paper, Scissors?");
            string? choice = Console.ReadLine();
            if (choice != null)
            {
                choice = choice.ToLower();

                int playerChoice = 0;

                if (choice == "rock")
                {
                    playerChoice = 0;
                }
                else if (choice == "paper")
                {
                    playerChoice = 1;
                }
                else if (choice == "scissors")
                {
                    playerChoice = 2;
                }

                Random rnd = new Random();
                int compChoice = rnd.Next(0, 3);

                if (playerChoice == compChoice)
                {
                    Console.WriteLine("Draw");
                }
                else if (playerChoice - compChoice == 1 || playerChoice - compChoice == -2)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }
        }
        public static string TriangleType(double length1, double length2, double length3)
        {
            string type;
            if (length1 == length2 && length2 == length3)
            {
                type = "equilateral";
            }
            else if (length1 == length2 || length2 == length3 || length1 == length3)
            {
                type = "isoceles";
            }
            else
            {
                type = "scalene";
            }
            return type;
        }
        public static void ConcertSales()
        {
            double price;

            Console.WriteLine("Enter the price of a concert ticket");
            string? priceString = Console.ReadLine();

            if (priceString != null)
            {
                bool converted = double.TryParse(priceString, out price);

                if (converted == false)
                {
                    Console.WriteLine("Cannot convert input to numeric type double");
                }

                else
                {
                    Console.WriteLine("Enter the number of tickets sold");
                    int numTickets = Convert.ToInt32(Console.ReadLine());
                    double totalSales = price * numTickets;

                    Console.WriteLine($"The total sales were £{totalSales}");
                }
            }   
        }
        public static bool AgeEligibility(DateTime DoB)
        {
            DateTime presentDate = DateTime.Now;
            TimeSpan difference = presentDate - DoB;

            int days = (int)difference.TotalDays;
            
            int years = days / 365;

            if (years >= 18 && years <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AgeEligibility2(DateTime DoB)
        {
            DateTime presentDate = DateTime.Now;
            
            if (presentDate.Year - DoB.Year > 18 && presentDate.Year - DoB.Year < 30) 
            {
                return true;
            }
            else if (presentDate.Year - DoB.Year == 18 && presentDate.Month < DoB.Month)
            {
                return true;
            }
            else if (presentDate.Year - DoB.Year == 18 && presentDate.Month == DoB.Month && presentDate.Day <= DoB.Day)
            {
                return true;
            }
            else if (presentDate.Year - DoB.Year == 30 && presentDate.Month > DoB.Month && presentDate.Day >= DoB.Day)
            {
                return true;
            }
            else if (presentDate.Year - DoB.Year == 30 && presentDate.Month == DoB.Month && presentDate.Day >= DoB.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}