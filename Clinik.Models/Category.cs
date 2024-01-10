namespace Clinik.Models
{
    public class Category : BaseEntity
    {
        public string  CategoryName { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
