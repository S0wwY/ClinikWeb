﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
