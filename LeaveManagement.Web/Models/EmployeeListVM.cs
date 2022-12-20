﻿using System.ComponentModel;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [DisplayName("First Name")]
        public string Firstname { get; set; }

        [DisplayName("Last Name")]
        public string Lastname { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }

        [DisplayName("Date Joined")]
        public string DateJoined { get; set; }
    }
}
