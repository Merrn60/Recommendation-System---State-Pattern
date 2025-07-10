using Movie_Book_states;
using Movie_Book_states.Book_Types;
using System;

public class BookRecommendationState : IRecommendationState
{
    public void Recommend(RecommendationContext context)
    {
        switch (context.Genre.ToLower())
        {
            case "romantic":
                context.SetState(new RomanticBookRecomendState());
                break;
            case "action":
                context.SetState(new ActionBookRecomendState());
                break;
            case "horror":
                context.SetState(new HorrorBookRecomendState());
                break;
            default:
                Console.WriteLine("No book recommendations available for this genre.");
                return;
        }

        context.Recommend(); // Call the recommend method on the new state  
    }
}