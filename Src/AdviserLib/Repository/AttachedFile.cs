using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class AttachedFile
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FileName { get; set; }
        public string Comment { get; set; }
        public long ContentId { get; set; }
        public long TopicId { get; set; }
        [ForeignKey("ContentId")]
        public virtual FileContent FileContent { get; set; }
    }
}
