using System.ComponentModel.DataAnnotations;

namespace EdlinSoftware.Adviser.Repository
{
    public partial class Text
    {
        [Key]
        public long Id { get; set; }
        public string RtfText { get; set; }
        public string PlainText { get; set; }
    }
}
