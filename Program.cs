namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SelectionQuestions.BuzzFizz(18));
            Console.WriteLine(SelectionQuestions.IsVowel("a"));
            Console.WriteLine(SelectionQuestions.IsVowel2("b"));
            SelectionQuestions.DiceRoll();
            Console.WriteLine(SelectionQuestions.AngleType(87));
            SelectionQuestions.RockPaperScissors();
            Console.WriteLine(SelectionQuestions.TriangleType(3, 4, 4));
            SelectionQuestions.ConcertSales();
            DateTime DoB = new DateTime(2007, 6, 9);
            Console.WriteLine(SelectionQuestions.AgeEligibility(DoB));
            Console.WriteLine(SelectionQuestions.AgeEligibility2(DoB));
        }
    }
}