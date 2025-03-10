using System.ComponentModel.DataAnnotations;

namespace ecom_web_api.Entities

{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }


        public bool IsVerified { get; set; } = false;

    }

}
