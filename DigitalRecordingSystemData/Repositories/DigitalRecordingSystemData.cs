using DigitalRecordingSystemData.Models;
using DigitalRecordingSystemData.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DigitalRecordingSystemData.Repositories
{
    public class DigitalRecordingRepository : IDigitalRecordingRepository
{
    private readonly ApplicationDbContext _context;

    public DigitalRecordingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DigitalRecordingModel> AddAsync(DigitalRecordingModel recording)
    {
        _context.DigitalRecordings.Add(recording);
        await _context.SaveChangesAsync();
        return recording;
    }

    public async Task<DigitalRecordingModel> EndRecordingAsync(int id, DateTime endTime)
    {
        var recording = await _context.DigitalRecordings.FindAsync(id);
        if (recording == null) return null;

        recording.EndTime = endTime;
        await _context.SaveChangesAsync();
        return recording;
    }

    public async Task<IEnumerable<DigitalRecordingModel>> GetAllAsync()
    {
        return await _context.DigitalRecordings.ToListAsync();
    }

    public async Task<DigitalRecordingModel> GetByDateAsync(DateTime date)
    {
        return await _context.DigitalRecordings
            .FirstOrDefaultAsync(r => r.StartTime.Date == date.Date);
    }
}
}
