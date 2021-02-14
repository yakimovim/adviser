using System.ComponentModel.DataAnnotations;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class FileContent
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public byte[] Content { get; set; }
    }
}
