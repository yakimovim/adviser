using System.ComponentModel.DataAnnotations;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class AttachedLink
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Url { get; set; }
        public string Comment { get; set; }
        public long TopicId { get; set; }
    }
}
