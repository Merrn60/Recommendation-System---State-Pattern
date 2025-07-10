using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states.Movie_Types
{
    internal class ActionMovieRecomendState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("Action Movie Recommendations:");
            Console.WriteLine("1. Mad Max: Fury Road");
            Console.WriteLine("2. John Wick");

            if (context.IsNewYear)
            {
                Console.WriteLine("Special New Year Movie Recommendations:");
                Console.WriteLine("1. New Year’s Eve");
                Console.WriteLine("2. When Harry Met Sally...");
            }
        }
    }
}
