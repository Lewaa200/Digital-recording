using DigitalRecordingSystemData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRecordingSystemData.Repositories
{
    public interface IDigitalRecordingRepository
    {
        Task<DigitalRecordingModel> AddAsync(DigitalRecordingModel recording);
        Task<DigitalRecordingModel> EndRecordingAsync(int id, DateTime endTime);
        Task<IEnumerable<DigitalRecordingModel>> GetAllAsync();
        Task<DigitalRecordingModel> GetByDateAsync(DateTime date);
    }
}

