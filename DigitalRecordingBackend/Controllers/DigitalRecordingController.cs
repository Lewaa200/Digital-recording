using DigitalRecordingBackend.Models;
using DigitalRecordingBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DigitalRecordingBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DigitalRecordingController : ControllerBase
    {
        private readonly IDigitalRecordingService _service;

        public DigitalRecordingController(IDigitalRecordingService service)
        {
            _service = service;
        }

        [HttpPost("start")]
        public async Task<IActionResult> Start([FromBody] StartRecordingRequest request)
        {
            if (request == null || request.StartTime == default)
            {
                return BadRequest("Invalid request data");
            }

            var recording = await _service.StartRecordingAsync(request.StartTime, request.NFC, request.QRCode);
            return Ok(recording);
        }

        [HttpPost("end")]
        public async Task<IActionResult> End([FromBody] EndRecordingRequest request)
        {
            if (request == null || request.EndTime == default || request.ID == default)
            {
                return BadRequest("Invalid request data");
            }

            var recording = await _service.EndRecordingAsync(request.ID, request.EndTime);
            return Ok(recording);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var recordings = await _service.GetAllRecordingsAsync();
            return Ok(recordings);
        }

        [HttpGet("getByDate")]
        public async Task<IActionResult> GetByDate([FromQuery] DateTime date)
        {
            var recording = await _service.GetRecordingByDateAsync(date);
            return Ok(recording);
        }
    }
}
