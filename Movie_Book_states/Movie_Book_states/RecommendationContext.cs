using Movie_Book_states;
using Movie_Book_states.Book_Types;
using Movie_Book_states.Movie_Types;

public class RecommendationContext
{
    private IRecommendationState _state;
    public bool IsNewYear { get; set; }
    public string Genre { get; set; }

    public void SetState(IRecommendationState state)
    {
        _state = state;
    }

    public void Recommend()
    {
        _state.Recommend(this);
    }

}