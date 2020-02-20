namespace WebApiExa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producttb")]
    public partial class Producttb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string productName { get; set; }
    }
}
