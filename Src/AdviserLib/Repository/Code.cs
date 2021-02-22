using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class Code
    {
        public Code()
        {
            LanguageId = 1;
            Platforms = new HashSet<Platform>();
        }
    
        [Key]
        public long Id { get; set; }
        public long TextId { get; set; }
        public long LanguageId { get; set; }
        public long TopicId { get; set; }
    
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
        [ForeignKey("TextId")]
        public virtual Text Text { get; set; }

        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
