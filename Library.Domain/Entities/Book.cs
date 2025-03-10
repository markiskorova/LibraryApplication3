using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public bool IsCheckedOut { get; set; }
    }
}