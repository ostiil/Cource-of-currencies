using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Contexts
{

    [Table("currency")]
    public record Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_currency")]
        public int Id { get; set; }
        [Column("name_currency")]
        public string Name { get; set; }
        public int? Favorites { get; set; }
        
    }
}
