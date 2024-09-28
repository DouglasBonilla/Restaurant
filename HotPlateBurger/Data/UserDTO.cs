using System.ComponentModel.DataAnnotations.Schema;

namespace HotPlateBurger.Data
{
    public class UserDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        public DateTime CreatedAt { get; set; }
        public byte Status { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }

        [NotMapped]
        public string ConfirmPassword_aux { get; set; }
    }
}
