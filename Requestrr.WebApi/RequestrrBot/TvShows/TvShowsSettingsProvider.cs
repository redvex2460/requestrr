using System.Collections.Generic;
using System.Linq;
using Requestrr.WebApi.RequestrrBot.DownloadClients.Sonarr;

namespace Requestrr.WebApi.RequestrrBot.TvShows
{
    public class TvShowsSettingsProvider
    {
        public TvShowsSettings Provide()
        {
            dynamic settings = SettingsFile.Read();
            var categories = (List<SonarrCategorySettings>)settings.DownloadClients.Sonarr.Categories.ToObject<List<SonarrCategorySettings>>();

            return new TvShowsSettings
            {
                Client = settings.TvShows.Client,
                Command = settings.TvShows.Command,
                Restrictions = settings.TvShows.Restrictions,
                Categories = categories.Select(x => x.Id).ToArray(),
            };
        }
    }
}