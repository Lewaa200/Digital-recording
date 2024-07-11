using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRecordingSystemData.Models
{
    public class DigitalRecordingModel
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string NFC { get; set; }
        public string QRCode { get; set; }
    }
}
