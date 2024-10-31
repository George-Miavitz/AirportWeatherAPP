using AirportWeatherAppAPI.Data;
using System.Threading.Tasks;

namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public interface IGetFeedbackByUserID
    {
        Task<IEnumerable<Feedback>> FeedbackSearch(int SearchFeedback);
    }
}