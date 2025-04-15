namespace BIA_Task_10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Sales = new HashSet<Sale>();
        }

        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        public int? DirectoryID { get; set; }

        public int ReleaseYear { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReceptionDate { get; set; }

        public decimal AssessedValue { get; set; }

        [Required]
        [StringLength(255)]
        public string Descriptions { get; set; }

        public virtual Directory Directory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
