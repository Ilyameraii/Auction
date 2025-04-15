namespace BIA_Task_10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public int UsersID { get; set; }

        [Required]
        [StringLength(255)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(255)]
        public string UserPassword { get; set; }
    }
}
