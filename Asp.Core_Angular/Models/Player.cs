using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Asp.Core_Angular.Models
{
    public partial class Player
    {
     [Key]
        public int? Id { get; set; }
        public int? ShortNo { get; set; }
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }
    }
}
