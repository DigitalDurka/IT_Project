using System.Text.Json.Serialization;
using Domain.Models;

namespace IT_Project.Views
{
    public class UserSearchView
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("phonenumber")]
        public string Phone { get; set; }

        [JsonPropertyName("FIO")]
        public string FIO { get; set; }

        [JsonPropertyName("role")]
        public Role Role { get; set; }

        [JsonPropertyName("login")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}