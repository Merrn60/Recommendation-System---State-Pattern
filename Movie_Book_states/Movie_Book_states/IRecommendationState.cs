using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Book_states
{
    public interface IRecommendationState
    {
        void Recommend(RecommendationContext context);
    }
}
