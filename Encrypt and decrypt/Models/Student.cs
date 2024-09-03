using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Gpa { get; set; }
    }
}
