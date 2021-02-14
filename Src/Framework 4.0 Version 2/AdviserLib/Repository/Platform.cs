using System.ComponentModel.DataAnnotations;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class Platform
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
