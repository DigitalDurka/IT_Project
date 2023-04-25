using Domain.Models;

namespace Domain.IRepositories
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        IEnumerable<Schedule> GetSheduleByDate(Doctor doctor, DateOnly date);
    }
}