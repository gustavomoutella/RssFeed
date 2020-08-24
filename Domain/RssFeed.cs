using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RssFeed
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string DatePublish { get; set; }
        public string Author { get; set; }
    }
}
