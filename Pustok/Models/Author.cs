using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Author:BaseEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Fullname { get; set; }
    }
}
