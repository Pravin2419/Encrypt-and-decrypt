using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class EmployeeDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
