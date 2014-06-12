namespace PrototypeEDUCOM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prototype.requests")]
    public partial class request
    {
        public request()
        {
            students = new HashSet<student>();
        }

        public int id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string state { get; set; }

        public int users_id { get; set; }

        public virtual user user { get; set; }

        public virtual ICollection<student> students { get; set; }
    }
}
