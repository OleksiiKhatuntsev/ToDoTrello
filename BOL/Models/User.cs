﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
