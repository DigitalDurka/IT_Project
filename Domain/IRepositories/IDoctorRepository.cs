using Domain.Models;

namespace domain.IRepositories
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetDoctorsBySpec(Specialization specialization);
    }
}