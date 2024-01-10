using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Models
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Clinic> Clinics { get; set; }
        public Category Category { get; set; }
    }
}
