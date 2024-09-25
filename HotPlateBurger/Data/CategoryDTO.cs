using System.ComponentModel.DataAnnotations.Schema;

namespace HotPlateBurger.Data
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public String Nombre { get; set; }
        [NotMapped]
        public int Top_Aux { get; set; }
    }
}


