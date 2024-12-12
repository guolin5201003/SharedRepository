namespace LoginFormASPCore6.Models
{
    public class LocalHardwares
    {
        public long ID { get; set; }
        public long StationId { get; set; }
        public string HardwareName { get; set; }
        public string HardwareType { get; set; }
        public string FrameId { get; set; }
        public bool IsMain { get; set; }
        public string ScreenShotRelativePath { get; set; }
        public string SerialNo { get; set; }
        public string MainBoardVersion { get; set; }
        public string DrawerVersion { get; set; }
    }
}
