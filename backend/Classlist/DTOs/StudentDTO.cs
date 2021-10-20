namespace Classlist.DTOs
{
    public class StudentDTO
    {
        public string Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public bool Registered { get; set; }
        public int? ClazzId { get; set; }
    }
}
