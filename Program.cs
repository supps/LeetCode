using LeetCodePractice;
using LeetCodePractice.Questions;

internal class Program
{
    private static void Main(string[] args)
    {
        IQuestionSolving question = new _17();
        question.Solve();
        Console.ReadKey();
    }
}