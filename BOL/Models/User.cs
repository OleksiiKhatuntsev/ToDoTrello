﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class User
    {
        [UIHint("HiddenInput")]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
