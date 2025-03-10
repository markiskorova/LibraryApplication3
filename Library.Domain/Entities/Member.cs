using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public partial class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}