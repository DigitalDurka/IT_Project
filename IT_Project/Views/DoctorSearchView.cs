using System.Text.Json.Serialization;
using Domain.Models;

namespace IT_Project.Views
{
    public class DoctorSearchView
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("FIO")]
        public string Fio { get; set; }

        [JsonPropertyName("spec")]
        public Specialization Spec { get; set; }

    }
}