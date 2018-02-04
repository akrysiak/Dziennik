namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TPrzedmiot")]
    public partial class TPrzedmiot
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nazwa { get; set; }

        public int IdNauczyciela { get; set; }
    }
}
