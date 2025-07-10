using Movie_Book_states;
using Movie_Book_states.Movie_Types;
using System;

public class MovieRecommendationState : IRecommendationState
{
    public void Recommend(RecommendationContext context)
    {
        switch (context.Genre.ToLower())
        {
            case "romantic":
                RomanticMovieRecomendState romanticMovieRecomendState = new RomanticMovieRecomendState();
                break;
            case "action":
                ActionMovieRecomendState actionMovieRecomendState = new ActionMovieRecomendState();
                break;
            case "horror":
                HorrorMovieRecomendState horrorMovieRecomendState = new HorrorMovieRecomendState();
                
                break;
            default:
                Console.WriteLine("No movie recommendations available for this genre.");
                return;
        }

        context.Recommend(); // Call the recommend method on the new state  
    }
}