namespace LoginFormASPCore6.Models
{
    public class LocalAssets
    {
        public long ID { get; set; }
        public long StationId { get; set; }
        public string StationName { get; set; }
        public string MedLogicVersion { get; set; }
        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public string PhysicalMemory { get; set; }
        public string CPU { get; set; }
        public string ClientSQLServerVersion { get; set; }

        public string? CabImage { get; set; }
        public DateTime MedLogicInstallDate { get; set; }
        public DateTime UpTimeStamp { get; set; }
    }
}
