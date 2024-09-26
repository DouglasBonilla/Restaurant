using System.ComponentModel.DataAnnotations.Schema;

namespace HotPlateBurger.Data
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public String Name { get; set; }
        [NotMapped]
        public int Top_Aux { get; set; }
    }
}


