using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class DocumentAttachment
    {
        public int Id { get; set; }
        public string? FileExtension { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime? DateUploaded { get; set; }
    }
}
