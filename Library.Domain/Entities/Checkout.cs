using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public partial class Checkout
    {
        public int CheckoutId { get; set; }
        public int? MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}