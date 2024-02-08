using System.ComponentModel;

namespace WinFormsApp.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateOnly? Birthday { get; set; }
        public string? Color { get; set; }
        public string? Married { get; set; }
        [DisplayName("Submit Date")]
        public DateTime? SubmitDate { get; set; }
    }
}
