using System;
using System.Collections.Generic;

namespace Requestrr.WebApi.config
{
    public class DownloadClientsSettings
    {
        public OmbiSettings Ombi { get; set; }
        public RadarrSettings Radarr { get; set; }
        public SonarrSettings Sonarr { get; set; }
    }

    public class OmbiSettings
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiUsername { get; set; }
        public bool UseSSL { get; set; }
        public string Version { get; set; }
    }

    public class RadarrSettings
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public int MovieProfileId { get; set; }
        public string MovieRootFolder { get; set; }
        public string MovieMinimumAvailability { get; set; }
        public int[] MovieTags { get; set; }
        public int AnimeProfileId { get; set; }
        public string AnimeRootFolder { get; set; }
        public string AnimeMinimumAvailability { get; set; }
        public int[] AnimeTags { get; set; }
        public bool UseSSL { get; set; }
        public bool SearchNewRequests { get; set; }
        public bool MonitorNewRequests { get; set; }
        public string Version { get; set; }
    }

    public class SonarrSettings
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public List<SonarrCategorySettings> Categories { get; set; } = new List<SonarrCategorySettings>();
        public bool UseSSL { get; set; }
        public bool SearchNewRequests { get; set; }
        public bool MonitorNewRequests { get; set; }
        public string Version { get; set; }
    }

    public enum SeriesType
    {
        Standard,
        Anime,
        Daily
    }

    public class SonarrCategorySettings
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SeriesType SeriesType { get; set; }
        public int ProfileId { get; set; }
        public string RootFolder { get; set; }
        public int LanguageId { get; set; }
        public int[] Tags { get; set; }
        public bool UseSeasonFolders { get; set; }
    }
}