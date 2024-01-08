namespace Clinik.Models
{
    public class Appointment : BaseEntity
    {
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string UserAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}

