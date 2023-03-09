using Internal;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine($"Math is marvelous!");
                    break;
                case "Science":
                    Console.WriteLine($"Science is superb!");
                    break;
                case "Spanish":
                    Console.WriteLine($"Spanish is spectacular!");
                    break;
                case "Culinary":
                    Console.WriteLine($"Culinary is cowabunga!");
                    break;
                default:
                    Console.WriteLine($"So cool! I've never taken {subject} before!");
                    break;
            }
        }
    }
}