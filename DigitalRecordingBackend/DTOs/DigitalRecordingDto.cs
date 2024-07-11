namespace DigitalRecordingBackend.DTOs
{
    public class DigitalRecordingDto
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string NFC { get; set; }
        public string QRCode { get; set; }
    }
}
