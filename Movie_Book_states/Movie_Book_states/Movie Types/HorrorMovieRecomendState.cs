using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states.Movie_Types
{
    internal class HorrorMovieRecomendState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("Horror Movie Recommendations:");
            Console.WriteLine("1. Get Out");
            Console.WriteLine("2. A Quiet Place");

            if (context.IsNewYear)
            {
                Console.WriteLine("Special New Year Movie Recommendations:");
                Console.WriteLine("1. New Year’s Eve");
                Console.WriteLine("2. When Harry Met Sally...");
            }
        }
    }
}
