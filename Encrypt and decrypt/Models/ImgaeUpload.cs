using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class ImgaeUpload
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public int Price { get; set; }
        public string ImgaePath { get; set; } = null!;
    }
}
