using System;

class Program
{
    static void Main(string[] args)
    {
        var context = new RecommendationContext();

        // User chooses the recommendation type  
        Console.WriteLine("Choose recommendation type: 1 for Books, 2 for Movies:");
        var choice = Console.ReadLine();

        // Set state depending on user selection  
        if (choice == "1")
        {
            context.SetState(new BookRecommendationState());
        }
        else if (choice == "2")
        {
            context.SetState(new MovieRecommendationState());
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting.");
            return;
        }

        // User chooses genre  
        Console.WriteLine("Choose a genre: romantic, action, horror:");
        context.Genre = Console.ReadLine();

        // Check if it's New Year  
        Console.WriteLine("Is it New Year? (yes/no):");
        var isNewYearInput = Console.ReadLine();
        context.IsNewYear = isNewYearInput.Equals("yes", StringComparison.OrdinalIgnoreCase);

        // Get recommendations based on the context  
        context.Recommend();
    }
}