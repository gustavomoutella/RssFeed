using System.ComponentModel.DataAnnotations;

namespace RssFeed.Models
{
    public class UserDataViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
