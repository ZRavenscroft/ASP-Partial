using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Genre:BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
