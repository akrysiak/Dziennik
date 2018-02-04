namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TKlasa")]
    public partial class TKlasa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Nazwa { get; set; }

        public int Id_Wychowawcy { get; set; }
    }
}
