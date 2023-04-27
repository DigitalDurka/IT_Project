using Domain.IRepositories;
using Domain.Models;

namespace Domain.IRepositories
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        IEnumerable<Schedule> GetScheduleByDate(Doctor doctor, DateOnly date);
    }
}