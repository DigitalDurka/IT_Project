using BD.Models;
using Domain.Models;

namespace BD.Converters
{
    public static class DoctorConvert
    {
        public static Doctor? ToDomain(this DoctorModel entity)
        {
            return new Doctor(

                entity.Id,
                entity.Fio,
                entity.Spec.ToDomain());
        }

        public static DoctorModel ToModel(this Doctor entity)
        {
            return new DoctorModel
            {
                Id = entity.Id,
                Fio = entity.Fio,
                Spec = entity.Spec.ToModel()
            };
        }
    }
}