using System;
using System.Collections.Generic;

namespace Portfolio.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Content { get; set; }
        public DateTime? PublishTime { get; set; }
    }
}
