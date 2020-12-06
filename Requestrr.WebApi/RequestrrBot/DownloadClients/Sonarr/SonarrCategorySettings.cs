using System;

namespace Requestrr.WebApi.RequestrrBot.DownloadClients.Sonarr
{
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