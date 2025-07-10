using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states.Book_Types
{
    internal class RomanticBookRecomendState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("Romantic Book Recommendations:");
            Console.WriteLine("1. Pride and Prejudice");
            Console.WriteLine("2. The Notebook");

            if (context.IsNewYear)
            {
                Console.WriteLine("Special New Year Book Recommendations:");
                Console.WriteLine("1. The Best New Year Ever");
                Console.WriteLine("2. New Year, New You");
            }
        }
    }
}
