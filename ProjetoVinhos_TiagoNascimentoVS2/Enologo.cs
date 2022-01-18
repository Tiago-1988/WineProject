namespace ProjetoVinhos_TiagoNascimentoVS2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enologo")]
    public partial class Enologo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enologo()
        {
            Vinhoes = new HashSet<Vinho>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vinho> Vinhoes { get; set; }
    }
}
