using System;

namespace Requestrr.WebApi.RequestrrBot.TvShows
{
    public class TvShowsSettings
    {
        public string Client { get; set; }
        public string Command { get; set; }
        public string Restrictions { get; set; }
        public Guid[] Categories { get; set; } = Array.Empty<Guid>();
    }
}