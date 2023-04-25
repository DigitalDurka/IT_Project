using Domain.Models;

namespace Domain.IRepositories
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetDoctorsBySpec(Specialization specialization);
    }
}