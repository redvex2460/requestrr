using System.Collections.Generic;

namespace Requestrr.WebApi.RequestrrBot.DownloadClients.Sonarr
{
    public class SonarrSettings
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public List<SonarrCategorySettings> Categories { get; set; } = new List<SonarrCategorySettings>();
        public bool SearchNewRequests { get; set; }
        public bool MonitorNewRequests { get; set; }
        public bool UseSSL { get; set; }
        public string Version { get; set; }
    }
}