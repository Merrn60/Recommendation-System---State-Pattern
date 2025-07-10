using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states
{
    internal class NewYearRecomendState : IRecommendationState
    {
        public void Recommend(RecommendationContext context)
        {
            Console.WriteLine("New Year Special Recommendations:");
            Console.WriteLine("- Auld Lang Syne (Movie)");
            Console.WriteLine("- New Year’s Eve (Movie)");
            Console.WriteLine("- New Year (Book) by Tilly Tennant");
        }
    }
}
