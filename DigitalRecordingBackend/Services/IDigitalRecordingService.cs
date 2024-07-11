using DigitalRecordingBackend.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalRecordingBackend.Services
{
    public interface IDigitalRecordingService
    {
        Task<DigitalRecordingDto> StartRecordingAsync(DateTime startTime, string nfc, string qrCode);
        Task<DigitalRecordingDto> EndRecordingAsync(int id, DateTime endTime);
        Task<IEnumerable<DigitalRecordingDto>> GetAllRecordingsAsync();
        Task<DigitalRecordingDto> GetRecordingByDateAsync(DateTime date);
    }
}
