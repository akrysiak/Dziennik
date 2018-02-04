namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUczen")]
    public partial class TUczen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Imie { get; set; }

        [Required]
        [StringLength(40)]
        public string Nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataUrodzenia { get; set; }

        [Required]
        [StringLength(50)]
        public string Ulica { get; set; }

        [Required]
        [StringLength(30)]
        public string Miejscowosc { get; set; }

        [Required]
        [StringLength(6)]
        public string Kod { get; set; }

        [Required]
        [StringLength(12)]
        public string Kontakt { get; set; }

        public int IdKlasy { get; set; }
    }
}
