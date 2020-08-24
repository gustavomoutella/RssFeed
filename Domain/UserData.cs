using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
