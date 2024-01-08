namespace Clinik.Models
{
    public class DoctorCategory : BaseEntity
    {
        public string  CategoryName { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
