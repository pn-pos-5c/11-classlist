#nullable disable

namespace ClasslistDb
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public bool Registered { get; set; }
        public int? ClazzId { get; set; }

        public virtual Clazz Clazz { get; set; }
    }
}
