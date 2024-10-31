using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public interface IGetFeedbackByUserID
    {
        Task<int> FeedbackSearch(Feedback SearchFeedback);
    }
}