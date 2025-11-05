using System.ComponentModel.DataAnnotations.Schema;

namespace Mera_yani_shweta_ka_app.models.User
{
    [Table("CustomerDetails")]
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? MobileNo { get; set; }

        public string? ProfileImagePath { get; set; }

        // Fix: Add the missing OrderDetails property to resolve CS1061
        //public List<Order> OrderDetails { get; set; } = new List<Order>();

        //public List<Order> Orders { get; set; } = new(); // ✔️ Clean and clear

    }


    

}
