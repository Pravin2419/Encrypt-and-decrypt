using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
