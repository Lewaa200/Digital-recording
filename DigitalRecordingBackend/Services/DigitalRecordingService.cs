using DigitalRecordingBackend.DTOs;
using DigitalRecordingSystemData.Models;
using DigitalRecordingSystemData.Repositories;

namespace DigitalRecordingBackend.Services
{
    public class DigitalRecordingService : IDigitalRecordingService
    {
        private readonly IDigitalRecordingRepository _repository;

        public DigitalRecordingService(IDigitalRecordingRepository repository)
        {
            _repository = repository;
        }

        public async Task<DigitalRecordingDto> StartRecordingAsync(DateTime startTime, string nfc, string qrCode)
        {
            var recording = new DigitalRecordingModel
            {
                StartTime = startTime,
                NFC = nfc,
                QRCode = qrCode
            };

            var result = await _repository.AddAsync(recording);
            return new DigitalRecordingDto
            {
                ID = result.ID,
                StartTime = result.StartTime,
                EndTime = result.EndTime,
                NFC = result.NFC,
                QRCode = result.QRCode
            };
        }

        public async Task<DigitalRecordingDto> EndRecordingAsync(int id, DateTime endTime)
        {
            var result = await _repository.EndRecordingAsync(id, endTime);
            if (result == null)
            {
                throw new KeyNotFoundException("Recording not found");
            }

            return new DigitalRecordingDto
            {
                ID = result.ID,
                StartTime = result.StartTime,
                EndTime = result.EndTime,
                NFC = result.NFC,
                QRCode = result.QRCode
            };
        }

        public async Task<IEnumerable<DigitalRecordingDto>> GetAllRecordingsAsync()
        {
            var recordings = await _repository.GetAllAsync();
            return recordings.Select(r => new DigitalRecordingDto
            {
                ID = r.ID,
                StartTime = r.StartTime,
                EndTime = r.EndTime,
                NFC = r.NFC,
                QRCode = r.QRCode
            }).ToList();
        }

        public async Task<DigitalRecordingDto> GetRecordingByDateAsync(DateTime date)
        {
            var result = await _repository.GetByDateAsync(date);
            if (result == null)
            {
                throw new KeyNotFoundException("Recording not found");
            }

            return new DigitalRecordingDto
            {
                ID = result.ID,
                StartTime = result.StartTime,
                EndTime = result.EndTime,
                NFC = result.NFC,
                QRCode = result.QRCode
            };
        }
    }
}