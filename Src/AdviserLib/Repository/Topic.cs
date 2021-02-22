using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class Topic
    {
        public Topic()
        {
            AttachedFiles = new HashSet<AttachedFile>();
            AttachedLinks = new HashSet<AttachedLink>();
            Codes = new HashSet<Code>();
            SubTopics = new HashSet<Topic>();
        }
    
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        [MaxLength(255)]
        public string Tooltip { get; set; }
        public long? ParentId { get; set; }
        public long TextId { get; set; }
    
        public virtual ICollection<AttachedFile> AttachedFiles { get; set; }
        public virtual ICollection<AttachedLink> AttachedLinks { get; set; }
        public virtual ICollection<Code> Codes { get; set; }
        public virtual Text Text { get; set; }
        public virtual ICollection<Topic> SubTopics { get; set; }
        [ForeignKey("ParentId")]
        public virtual Topic Parent { get; set; }
    }
}
