namespace LoginFormASPCore6.Models
{
    public class LocalUpgradeInfo
    {
        public long ID { get; set; }
        public long StationId { get; set; }
        public string StationName { get; set; }
        public string CurrentVersion { get; set; }
        public string VersionTo { get; set; }
        public string Sate { get; set; }
        public DateTime ScheduleDateTime { get; set; }
    }
}
