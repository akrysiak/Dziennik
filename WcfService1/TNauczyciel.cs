namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TNauczyciel")]
    public partial class TNauczyciel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Nauczyciel { get; set; }
    }
}
