using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states.Book_Types
{
    internal class ActionBookRecomendState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("Action Book Recommendations:");
            Console.WriteLine("1. The Hunger Games");
            Console.WriteLine("2. The Da Vinci Code");

            if (context.IsNewYear)
            {
                Console.WriteLine("Special New Year Book Recommendations:");
                Console.WriteLine("1. The Best New Year Ever");
                Console.WriteLine("2. New Year, New You");
            }
        }
    }
}
