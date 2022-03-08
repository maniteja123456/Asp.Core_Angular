using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Asp.Core_Angular.Models
{
    public partial class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DispalyOrder { get; set; }
    }
}
