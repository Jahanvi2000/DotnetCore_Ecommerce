using System.ComponentModel.DataAnnotations;

namespace DemoApp.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(10)]
        public string Number { get; set; }
    }
}
