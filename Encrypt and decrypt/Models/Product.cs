using System;
using System.Collections.Generic;

namespace Encrypt_and_decrypt.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
