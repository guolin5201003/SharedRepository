namespace LoginFormASPCore6.Models
{
    public class LocalIssueTracking
    {
        public long ID { get; set; }
        public long StationId { get; set; }
        public string IssueId { get; set; }
        public string IssueDesc { get; set; }
        public string States { get; set; }
        public string LogsRelativePath { get; set; }
        public string ScreenShotRelativePath { get; set; }

    }
}
