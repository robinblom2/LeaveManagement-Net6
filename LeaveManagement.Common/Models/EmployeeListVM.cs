using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }
    }
}
