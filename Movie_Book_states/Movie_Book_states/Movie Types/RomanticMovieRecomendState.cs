using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states.Movie_Types
{
    internal class RomanticMovieRecomendState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("Romantic Movie Recommendations:");
            Console.WriteLine("1. The Notebook");
            Console.WriteLine("2. La La Land");

            if (context.IsNewYear)
            {
                Console.WriteLine("Special New Year Movie Recommendations:");
                Console.WriteLine("1. New Year’s Eve");
                Console.WriteLine("2. When Harry Met Sally...");
            }
        }
    }
}
