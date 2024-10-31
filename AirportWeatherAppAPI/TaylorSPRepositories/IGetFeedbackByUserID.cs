using AirportWeatherAppAPI.Data;
using System.Threading.Tasks;

//Interface for GetFeedbackByUserID created by Taylor Miavitz
namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public interface IGetFeedbackByUserID
    {
        Task<IEnumerable<Feedback>> FeedbackSearch(int SearchFeedback);
    }
}