namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOcena")]
    public partial class TOcena
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Ocena { get; set; }

        public int IdNauczyciela { get; set; }

        public int IdUcznia { get; set; }

        public int IdKlasy { get; set; }

        public int IdPrzedmiot { get; set; }
    }
}
