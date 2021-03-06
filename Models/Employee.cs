using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontend_358.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2)]

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Compare("Email", ErrorMessage = "Password and Compare Password must be same")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}