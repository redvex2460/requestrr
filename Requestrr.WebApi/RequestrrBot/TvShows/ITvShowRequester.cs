using System;
using System.Threading.Tasks;

namespace Requestrr.WebApi.RequestrrBot.TvShows
{
    public interface ITvShowRequester
    {
        Task<TvShowRequestResult> RequestTvShowAsync(Guid categoryId, TvShowUserRequester requester, TvShow tvShow, TvSeason seasons);
    }

    public class TvShowRequestResult
    {
        public bool WasDenied { get; set; }
    }
}