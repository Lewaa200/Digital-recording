namespace DigitalRecordingBackend.Models
{
    public class StartRecordingRequest
    {
        public DateTime StartTime { get; set; }
        public string NFC { get; set; }
        public string QRCode { get; set; }
    }
}
